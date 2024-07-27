using interface_me.Interfaces;

namespace interface_me.models
{
    internal class responseActivation : IResponse, IActivationPin
    {
        public string activation { get; set; }
        public string Message { get; set; }
        public int Code { get; internal set; }
    }


}
