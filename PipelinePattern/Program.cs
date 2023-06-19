// 使用範例
Image originalImage = LoadImage("input.jpg");

ImagePipeline pipeline = new ImagePipeline();
pipeline.AddProcessor(new ResizeProcessor());
pipeline.AddProcessor(new FilterProcessor());
pipeline.AddProcessor(new CompressProcessor());

Image processedImage = pipeline.ProcessImage(originalImage);
SaveImage(processedImage, "output.jpg");

Image LoadImage(string v)
{
    throw new NotImplementedException();
}

void SaveImage(Image processedImage, string v)
{
    throw new NotImplementedException();
}