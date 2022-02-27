using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFacebookLogic
{
    internal static class FacebookObjectsCloneMachine
    {
        internal static T FacecbookObjDeepClone<T>(this T i_ObjToClone) where T : class
        {
            using (Stream memoryStream = new MemoryStream())
            {
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(memoryStream, i_ObjToClone);
                memoryStream.Flush();
                memoryStream.Seek(0, SeekOrigin.Begin);
                T clonedObj = serializer.Deserialize(memoryStream) as T;
                return clonedObj;
            }
        }
    }
}