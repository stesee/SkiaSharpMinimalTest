# SkiaSharpMinimalTest

Reproduction of some skiaSharpIssue

Picture 32-33.bmp triggers some issue on reading from stream on calling "SKCodec.Create"`, while reading from file path and using system.drawing.bitmap is working.

```
 SKCodec.Create(stream, out var result); 
```

The issue seems to be intruduced with SkiaSharp 2.80.3. SkiaSharp 2.80.2 reads the image without issue.