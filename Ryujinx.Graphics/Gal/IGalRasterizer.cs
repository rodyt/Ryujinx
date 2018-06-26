namespace Ryujinx.Graphics.Gal
{
    public interface IGalRasterizer
    {
        void ClearBuffers(int RtIndex, GalClearBufferFlags Flags);

        bool IsVboCached(long Key, long DataSize);

        bool IsIboCached(long Key, long DataSize);

        void CreateVbo(long Key, byte[] Buffer);

        void CreateIbo(long Key, byte[] Buffer);

        void SetVertexArray(int VbIndex, int Stride, long VboKey, GalVertexAttrib[] Attribs);

        void SetIndexArray(long Key, int Size, GalIndexFormat Format);

        void DrawArrays(int First, int PrimCount, GalPrimitiveType PrimType);

        void DrawElements(long IboKey, int First, GalPrimitiveType PrimType);
    }
}