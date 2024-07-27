using interface_me.Interfaces;

namespace interface_me.models
{
    public class Response : IResponse, IPin, IActivationPin
    {
        public string pin { get; set; }
        public string activation { get; set; }
        public string Message { get; set; }
        public int Code { get; set; }


    }


}
