// <copyright file="ICoffeeMachineRepository.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

namespace CoffeeBrewing.Contracts
{
    public interface ICoffeeMachineRepository
    {
        ICoffeeMachine GetCoffeeMachine();
    }
}