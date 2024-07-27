using interface_me.Interfaces;

namespace interface_me.models
{
    internal class responseDigiPin :IResponse, IDigiPin, IPin
    {
        public string pin { get; set; }
        public string digiPin { get; set; }
        public string Message { get; set; }
    }


}
