
// 管線類別
public class ImagePipeline
{
    private List<IProcessor> processors;

    public ImagePipeline()
    {
        processors = new List<IProcessor>();
    }

    public void AddProcessor(IProcessor processor)
    {
        processors.Add(processor);
    }

    public Image ProcessImage(Image input)
    {
        foreach (var processor in processors)
        {
            input = processor.Process(input);
        }

        return input;
    }
}
