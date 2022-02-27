using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace WindowsFacebookLogic
{
    public static class CollageLogic
    {
        private static readonly Random sr_Random = new Random();
        private static AppManager m_AppManager = AppManager.AppManagerInstance();

        public static List<Photo> GetRandomPhotosFromAlbum(FacebookObjectCollection<Photo> i_AlbumPhotos, int i_AmountOfPhotos)
        {
            List<Photo> photosList = new List<Photo>();
            FacebookObjectCollection<Photo> albumPhotos = m_AppManager.GetAlbumCopy(i_AlbumPhotos);

            for (int i = 0; i < i_AmountOfPhotos; i++)
            {
                int choosenIndexItem = sr_Random.Next(0, albumPhotos.Count);
                Photo photo = albumPhotos[choosenIndexItem];
                photosList.Add(photo);
                albumPhotos.Remove(photo);
            }

            return photosList;
        }

        public static List<Photo> GetMostLikedPhotosFromAlbum(FacebookObjectCollection<Photo> i_AlbumPhotos, int i_AmountOfPhotos)
        {
            List<Photo> photosList = new List<Photo>();
            FacebookObjectCollection<Photo> albumPhotos = m_AppManager.GetAlbumCopy(i_AlbumPhotos);

            for (int i = 0; i < i_AmountOfPhotos; i++)
            {
                Photo photo = getMostLikedPhoto(albumPhotos);
                photosList.Add(photo);
                albumPhotos.Remove(photo);
            }

            return photosList;
        }

        private static Photo getMostLikedPhoto(FacebookObjectCollection<Photo> i_Photos)
        {
            int maxLiked = -1;
            Photo mostLikedPhoto = null;

            foreach (Photo currentPhoto in i_Photos)
            {
                int currentPhotoLikes = currentPhoto.LikedBy.Count();
                if (currentPhotoLikes > maxLiked)
                {
                    mostLikedPhoto = currentPhoto;
                    maxLiked = currentPhotoLikes;
                }
            }

            return mostLikedPhoto;
        }
    }
}
