using Infrastructure.Converters;
using System;

namespace BL.Converters
{
   public class UnixDateTimeConverter : IUnixDateTimeConverter
   {
      public DateTime ConvertUnixTimestampToDateTime(int unixTimestamp)
      {
         DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
         dtDateTime = dtDateTime.AddSeconds(unixTimestamp).ToLocalTime();
         return dtDateTime;
      }
   }
}
