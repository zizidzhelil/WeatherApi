namespace Infrastructure.UrlFactory
{
   public interface IUrlFactory
   {
      string Create(string builderName, params string[] args);
   }
}
