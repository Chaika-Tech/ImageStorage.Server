namespace ImageStorage.Server.Azure;

public class BlobStreamWrapper : Stream
{
    private readonly Stream _innerStream;
    public override long Length { get; }

    public BlobStreamWrapper(Stream innerStream, long length)
    {
        _innerStream = innerStream;
        Length = length;
    }

    public override bool CanRead => _innerStream.CanRead;
    public override bool CanSeek => _innerStream.CanSeek;
    public override bool CanWrite => _innerStream.CanWrite;
    public override long Position { get => _innerStream.Position; set => _innerStream.Position = value; }

    public override void Flush() => _innerStream.Flush();
    public override int Read(byte[] buffer, int offset, int count) => _innerStream.Read(buffer, offset, count);
    public override long Seek(long offset, SeekOrigin origin) => _innerStream.Seek(offset, origin);
    public override void SetLength(long value) => _innerStream.SetLength(value);
    public override void Write(byte[] buffer, int offset, int count) => _innerStream.Write(buffer, offset, count);
}
