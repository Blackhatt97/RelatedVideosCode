using System;
using System.Collections.Generic;
using System.Text;

namespace RelatedVideos.Models
{
    public interface IVideo
    {
        bool SameCategory(Video other);

        int SimilarCategory(Video other);

        int MixedCategory(Video other);

        bool SameGenre(Video other);

        int SimilarGenre(Video other);

        int MixedGenre(Video other);

        bool SameActor(Video other);

        int SimilarActor(Video other);

        int MixedActor(Video other);
    }
}
