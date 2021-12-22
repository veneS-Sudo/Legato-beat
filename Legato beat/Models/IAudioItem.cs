using System;

namespace Legato_beat.Models
{
    public interface IAudioItem
    {
        /// <summary>
        /// The metadata for the Album title.
        /// </summary>
        string Album { get; set; }

        /// <summary>
        /// The metadata for a Bitmap typed value to retrieve the information about the artwork for the Album of the media's original source.
        /// </summary>
        object AlbumImage { get; set; }

        /// <summary>
        /// The metadata for a CharSequence or string typed value to retrieve the information about the Uri of the artwork for the Album of the media's original source.
        /// </summary>
        string AlbumImageUri { get; set; }

        /// <summary>
        /// The metadata for a CharSequence or string typed value to retrieve the information about the artist of the media.
        /// </summary>
        string Artist { get; set; }

        /// <summary>
        /// The metadata for a Bitmap typed value to retrieve the information about the artwork for the media.
        /// </summary>
        object Image { get; set; }

        /// <summary>
        /// The metadata for a CharSequence or string typed value to retrieve the information about Uri of the artwork for the media.
        /// </summary>
        string ImageUri { get; set; }

        /// <summary>
        /// The metadata for a CharSequence or string typed value to retrieve the information about the date the media was created or published.
        /// </summary>
        DateTime Date { get; set; }

        /// <summary>
        /// The metadata for a int typed value to retrieve the information about the duration of the media.
        /// </summary>
        TimeSpan Duration { get; set; }

        /// <summary>
        /// The metadata for a CharSequence or string typed value to retrieve the information about the genre of the media.
        /// </summary>
        string Genre { get; set; }

        /// <summary>
        /// The metadata for a CharSequence or string typed value to retrieve the information about the Uri of the content.
        /// </summary>
        string AudioUri { get; set; }

        /// <summary>
        /// The metadata for a Rating2 typed value to retrieve the information about the overall rating for the media.
        /// </summary>
        object Rating { get; set; }

        /// <summary>
        /// The metadata for a CharSequence or string typed value to retrieve the information about the title of the media.
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// The metadata for a int typed value to retrieve the information about the year the media was created or published.
        /// </summary>
        int Year { get; set; }

        /// <summary>
        /// The file extension of the media item
        /// This may not be available for every item
        /// </summary>
        string FileExtension { get; set; }

        /// <summary>
        /// The name of the media file
        /// </summary>
        string FileName { get; set; }

        /// <summary>
        /// Indicates if the MediaItem is being live streamed
        /// </summary>
        bool IsLive { get; set; }

    }
}
