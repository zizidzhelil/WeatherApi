using System;

namespace Infrastructure.Converters
{
   public interface IUnixDateTimeConverter
   {
      DateTime ConvertUnixTimestampToDateTime(int unixTimestamp);
   }
}
