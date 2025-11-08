# LoremPicsum.cs
Web-API for [picsum.photos](https://picsum.photos/) the Lorem Ipsum for photos.

## Example
```cs
using LoremPicsumApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new LoremPicsum();
            string images = await api.GetImages();
            Console.WriteLine(images);
        }
    }
}
```
