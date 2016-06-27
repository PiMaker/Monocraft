using ICSharpCode.SharpZipLib.Zip;

namespace Monocraft.World.Serialization
{
    public static class WorldSerializer
    {
        public static void SaveWorld(WorldTile root, string filename)
        {
            var zipFile = new ZipFile(filename);



            zipFile.Close();
        }

        public static WorldTile LoadWorld(string filename)
        {
            return null;
        }
    }
}