
using System.Text;

namespace ServiceApp.Services {
    using Java.Util;
    using static Android.Provider.Settings;
    public class DeviceService : IDeviceService {
        public string? GetId() {
            var id = Secure.GetString(MainApplication.Current.ContentResolver, Secure.AndroidId);
            if(id != null) {
                var idBytes = (new UTF8Encoding().GetBytes(id));
                return UUID.NameUUIDFromBytes(idBytes)?.ToString();
            } else {
                return null;
            }
        }
    }
}
