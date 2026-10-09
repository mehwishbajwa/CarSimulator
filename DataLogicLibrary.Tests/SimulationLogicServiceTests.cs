using DataLogicLibrary.DTO;
using DataLogicLibrary.Services;
using DataLogicLibrary.DirectionStrategies;
using DataLogicLibrary.DirectionStrategies.Interfaces;

namespace DataLogicLibrary.Tests;

public class SimulationLogicServiceTests
{
    [Fact]
    public void PerformAction_WhenUserInputIs5_ShouldRestoreEnergyTo20()
    {
        // Arrange - Set up the initial values
        var currentStatus = new StatusDTO
        {
            EnergyValue = 10,
            GasValue = 10
        };

        var directionContext = new DirectionContext();

        SimulationLogicService.DirectionStrategyResolver resolver = movementAction =>
        {
            return null!;
        };

        var service = new SimulationLogicService(directionContext, resolver);

        // Act - Perform action 5 (restore energy)
        var result = service.PerformAction(5, currentStatus);

        // Assert - Check the expected results
        Assert.Equal(20, result.EnergyValue);
        Assert.Equal(10, result.GasValue);
    }

    [Fact]
    public void PerformAction_WhenUserInputIs6_ShouldRestoreGasTo20()
    {
        // Arrange
        var currentStatus = new StatusDTO
        {
            EnergyValue = 10,
            GasValue = 10
        };

        var directionContext = new DirectionContext();

        SimulationLogicService.DirectionStrategyResolver resolver =
            movementAction =>
            {
                return null!;
            };

        var service = new SimulationLogicService(directionContext, resolver);

        // Act
        var result = service.PerformAction(6, currentStatus);

        // Assert
        Assert.Equal(20, result.GasValue);
        Assert.Equal(10, result.EnergyValue);
    }

    [Fact]
    public void DecreaseStatusValues_WhenEnergyIsZero_ShouldNotGoBelowZero()
    {
        // Arrange
        var currentStatus = new StatusDTO
        {
            EnergyValue = 0,
            GasValue = 10
        };

        var directionContext = new DirectionContext();

        SimulationLogicService.DirectionStrategyResolver resolver =
            movementAction => null!;

        var service = new SimulationLogicService(
            directionContext, resolver);

        // Act
        var result = service.DecreaseStatusValues(1, currentStatus);

        // Assert
        Assert.Equal(0, result.EnergyValue);
    }


    [Fact]
    public void DecreaseStatusValues_WhenGasIsZero_ShouldNotGoBelowZero()
    {
        // Arrange
        var currentStatus = new StatusDTO
        {
            EnergyValue = 10,
            GasValue = 0
        };

        var directionContext = new DirectionContext();

        SimulationLogicService.DirectionStrategyResolver resolver =
            movementAction => null!;

        var service = new SimulationLogicService(
            directionContext, resolver);

        // Act
        var result = service.DecreaseStatusValues(1, currentStatus);

        // Assert
        Assert.Equal(0, result.GasValue);
    }


    [Fact]
    public void DecreaseStatusValues_WhenDriverIsResting_ShouldNotDecreaseGas()
    {
        // Arrange
        var currentStatus = new StatusDTO
        {
            EnergyValue = 10,
            GasValue = 10
        };

        var directionContext = new DirectionContext();

        SimulationLogicService.DirectionStrategyResolver resolver =
            movementAction => null!;

        var service = new SimulationLogicService(
            directionContext, resolver);

        // Act - Action 5 means resting
        var result = service.DecreaseStatusValues(5, currentStatus);

        // Assert - Gas should remain unchanged
        Assert.Equal(10, result.GasValue);
    }


    [Fact]
    public void DecreaseStatusValues_WhenDriving_ShouldDecreaseEnergyAndGas()
    {
        // Arrange
        var currentStatus = new StatusDTO
        {
            EnergyValue = 20,
            GasValue = 20
        };

        var directionContext = new DirectionContext();

        SimulationLogicService.DirectionStrategyResolver resolver =
            movementAction => null!;

        var service = new SimulationLogicService(
            directionContext, resolver);

        // Act - Action 3 means driving forward
        var result = service.DecreaseStatusValues(3, currentStatus);

        // Assert - Both values should decrease
        Assert.InRange(result.EnergyValue, 15, 19);
        Assert.InRange(result.GasValue, 15, 19);
    }


    [Fact]
    public void PerformAction_WhenGasIsAlready20_ShouldRemain20()
    {
        // Arrange
        var currentStatus = new StatusDTO
        {
            EnergyValue = 10,
            GasValue = 20
        };

        var directionContext = new DirectionContext();

        SimulationLogicService.DirectionStrategyResolver resolver =
            movementAction => null!;

        var service = new SimulationLogicService(
            directionContext, resolver);

        // Act - Action 6 refills gas
        var result = service.PerformAction(6, currentStatus);

        // Assert
        Assert.Equal(20, result.GasValue);
        Assert.Equal(10, result.EnergyValue);
    }


    [Fact]
    public void PerformAction_WhenEnergyIsAlready20_ShouldRemain20()
    {
        // Arrange
        var currentStatus = new StatusDTO
        {
            EnergyValue = 20,
            GasValue = 10
        };

        var directionContext = new DirectionContext();

        SimulationLogicService.DirectionStrategyResolver resolver =
            movementAction => null!;

        var service = new SimulationLogicService(
            directionContext, resolver);
        
        // Act - Action 5 restores energy
        var result = service.PerformAction(5, currentStatus);

        // Assert
        Assert.Equal(20, result.EnergyValue);
        Assert.Equal(10, result.GasValue);
    }

}

