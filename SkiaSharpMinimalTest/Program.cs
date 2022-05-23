using SkiaSharp;

Console.WriteLine("Hello, World!");

var tryToReadThese = Directory.GetFiles("./", "*.bmp");

foreach (var file in tryToReadThese)
{
    // this works
    var redingFromFilePathInsteadStream = SKCodec.Create(file);

    var stream = File.OpenRead(file);

#pragma warning disable CA1416 // Validate platform compatibility
    // this also works
    using var bmp = new System.Drawing.Bitmap(stream);
#pragma warning restore CA1416 // Validate platform compatibility

    stream.Position = 0;

    try
    {
        // this fails on Picture 32-33.bmp for no known reason
        var codec = SKCodec.Create(stream, out var result);
        Console.WriteLine($"{file} - {codec.EncodedFormat}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"failed to read {file} using SkiaSharp while system.drawing and creating from file succeeds - {ex.Message}, codec used in file is {redingFromFilePathInsteadStream.EncodedFormat}");
    }
}