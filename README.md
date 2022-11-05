# SkiaSharpMinimalTest

## Description

Reproduction of some skiaSharpIssue

Picture 32-33.bmp triggers some issue on reading from stream on calling "SKCodec.Create"`, while reading from file path and using system.drawing.bitmap is working.

```
 SKCodec.Create(stream, out var result); 
```

The issue seems to be introduced with SkiaSharp 2.80.3-2.88.0. SkiaSharp 2.80.2 reads the image without issue.

Bug seems to be already filed multiple times: https://github.com/mono/SkiaSharp/issues?q=is%3Aissue+Value+cannot+be+null.+%28Parameter+%27buffer%27%29+ and https://stackoverflow.com/questions/66096184/why-does-skiasharp-fail-to-load-some-image-in-uwp-when-calling-skbitmap-decode

## Update 10/2022

That was a bug, that got fixed in 2.88.3. Update to 2.88.3 to solve that issue:

https://github.com/mono/SkiaSharp/issues/1752#issuecomment-1261739228

```
dotnet add package SkiaSharp --version 2.88.3
```