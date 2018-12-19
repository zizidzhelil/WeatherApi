namespace Infrastructure.UrlFactory.UrlBuilder
{
   public interface IUrlBuilder
   {
      string Build(params string[] args);
   }
}
