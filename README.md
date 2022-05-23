# SkiaSharpMinimalTest

Reproduction of some skiaSharpIssue

Picture 32-33.bmp triggers some issue on reading from stream on calling "SKCodec.Create"`, while reading from file path and using system.drawing.bitmap is working.

```
 SKCodec.Create(stream, out var result); 
```

The issue seems to be intruduced with SkiaSharp 2.80.3-2.88.. SkiaSharp 2.80.2 reads the image without issue.

Bug seems to be already filed multiple times: https://github.com/mono/SkiaSharp/issues?q=is%3Aissue+Value+cannot+be+null.+%28Parameter+%27buffer%27%29+ and https://stackoverflow.com/questions/66096184/why-does-skiasharp-fail-to-load-some-image-in-uwp-when-calling-skbitmap-decode