using System;
using Core.Models;

namespace Web.Models.Mappers.Imp
{
    public class PushMapper:IPushMapper
    {
        public Push Map(PushForm form)
        {
            var device = new Push();
            device.Token = form.Token;
            device.Platform = form.Platform;
            device.UdId =form.UdId;
            device.OsVersion = form.OsVersion;
            device.CreatedDate = DateTime.Now;
            device.ModifiedDate = DateTime.Now;
            device.AppVersion = "1.0";
            return device;
        }

    }
}