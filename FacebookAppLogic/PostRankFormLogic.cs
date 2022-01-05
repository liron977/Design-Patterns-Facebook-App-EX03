using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class PostRankFormLogic
    {
        private readonly Dictionary<Post, int> r_UserPosts;
        private readonly FacebookAppManager r_AppManager = FacebookAppManager.Instance;


        public PostRankFormLogic()
        {
            r_UserPosts = new Dictionary<Post, int>();
        }


        public Dictionary<Post, int> UserPosts
        {
            get
            {
                return r_UserPosts;
            }
        }


        public void InitPostsList()
        {
            foreach(Post userPosts in r_AppManager.LoggedInUser.Posts)
            {
                try
                {
                    r_AppManager.UserPostsList.Add(userPosts);
                    r_UserPosts.Add(userPosts, postCommentCounter(userPosts));
                }
                catch
                {
                }
            }
        }

        public Post TheMostPopularPostByComments()
        {
            Post theMostCommentedPost = new Post();
            int maximumCountOfComments = 0;

            foreach(KeyValuePair<Post, int> item in r_UserPosts)
            {
                if(item.Key.Message != null)
                {
                    if(item.Value > maximumCountOfComments)
                    {
                        maximumCountOfComments = item.Value;
                        theMostCommentedPost = item.Key;
                    }
                }
            }

            return theMostCommentedPost;
        }

        private int postCommentCounter(Post i_UserPost)
        {
            int postCommentCounter = i_UserPost.Comments.Count;

            return postCommentCounter;
        }
    }
}