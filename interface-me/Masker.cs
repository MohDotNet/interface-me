using interface_me.Interfaces;

namespace interface_me
{
    public class Masker()
    {
        public IResponse Mask<T>(T mask) where T : class, IResponse 
        {
            if (mask is IActivationPin)
            {
                var entity = mask as IActivationPin;
                entity.activation = entity.activation.ToMasked();
            }

            if (mask is IPin)
            {
                var entity = mask as IPin;
                entity.pin = entity.pin.ToMasked();
            }

            if (mask is IDigiPin)
            {
                var entity = mask as IDigiPin;
                entity.digiPin = entity.digiPin.ToMasked();
            }

            return mask;
        }
    }
}
