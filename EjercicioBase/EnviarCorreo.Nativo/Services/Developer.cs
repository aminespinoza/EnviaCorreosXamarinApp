
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace EnviarCorreo.Nativo.Services
{
    public class Developer
    {
        private string _id;
        private string _email;

        [JsonProperty(PropertyName = "id")]
        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }

        [JsonProperty(PropertyName = "Email")]
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
            }
        }


        [Version]
        public string Version { get; set; }
        public string Event { get; set; }
    }
}
