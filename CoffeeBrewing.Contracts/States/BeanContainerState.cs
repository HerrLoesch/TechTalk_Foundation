using Zeiss.Semi.Mask.Foundation.MachineInterfaces.Contracts.Actuators;

namespace CoffeeBrewing.Contracts.States
{
    public abstract class BeanContainerState : ActuatorState
    {
        protected BeanContainerState(bool isBusy, string displayName) : base(isBusy, displayName)
        {
        }
    }
}
