using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace WindowsFacebookLogic
{
    internal static class CollageLogic
    {
        private static readonly Random sr_Random = new Random();
        private static AppManagerFacade s_AppManagerFacade = AppManagerFacade.AppManagerFacadeInstance();

        internal static List<Photo> GetRandomPhotosFromAlbum(Album i_AlbumPhotos, int i_AmountOfPhotos)
        {
            List<Photo> photosList = new List<Photo>();
            Album albumPhotos = i_AlbumPhotos.FacecbookObjDeepClone();
            int amountOfPhotosForCollage = getAmountOfPhotosForCollage(i_AlbumPhotos, i_AmountOfPhotos);

            for (int i = 0; i < amountOfPhotosForCollage; i++)
            {
                int choosenIndexItem = sr_Random.Next(0, albumPhotos.Photos.Count);
                Photo photo = albumPhotos.Photos[choosenIndexItem];
                photosList.Add(photo);
                albumPhotos.Photos.Remove(photo);
            }

            return photosList;
        }

        internal static List<Photo> GetMostLikedPhotosFromAlbum(Album i_AlbumPhotos, int i_AmountOfPhotos)
        {
            List<Photo> photosList = new List<Photo>();
            Album albumPhotos = i_AlbumPhotos.FacecbookObjDeepClone();
            int amountOfPhotosForCollage = getAmountOfPhotosForCollage(i_AlbumPhotos, i_AmountOfPhotos);

            for (int i = 0; i < amountOfPhotosForCollage; i++)
            {
                Photo photo = getMostLikedPhoto(albumPhotos);
                photosList.Add(photo);
                albumPhotos.Photos.Remove(photo);
            }

            return photosList;
        }

        private static int getAmountOfPhotosForCollage(Album i_AlbumPhotos, int i_AmountOfPhotos)
        {
            return Math.Min(i_AmountOfPhotos, i_AlbumPhotos.Photos.Count);
        }

        private static Photo getMostLikedPhoto(Album i_Album)
        {
            int maxLiked = -1;
            Photo mostLikedPhoto = null;

            foreach (Photo currentPhoto in i_Album.Photos)
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