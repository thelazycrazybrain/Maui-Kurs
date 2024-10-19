namespace ServiceApp.Services {
    using UIKit;
    public class DeviceService : IDeviceService {

        public string? GetId() {
            return UIDevice.CurrentDevice.IdentifierForVendor.AsString();
        }
    }
}
