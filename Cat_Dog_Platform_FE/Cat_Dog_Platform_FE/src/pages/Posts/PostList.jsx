import { useEffect, useState } from "react";
import ThumbUpOffAltIcon from "@mui/icons-material/ThumbUpOffAlt";
import ChatBubbleOutlineIcon from "@mui/icons-material/ChatBubbleOutline";
import SendIcon from "@mui/icons-material/Send";
import api from "../../api/api";
import { useRecoilValue } from "recoil";
import { accountAtom } from "../../atom/accountAtom";
import Modal from "@mui/material/Modal";
import Box from "@mui/material/Box";
import { createPostmodalStyle } from "../../style/style";
import { CreatePostModal } from "../../components/Modal";
import { PhotoArrageImgUrl } from "../../components/PhotoArrage";
import { CommentModal } from "../../components/CommentModal";

const PostList = () => {
  //const posts = useLoaderData();
  const account = useRecoilValue(accountAtom);
  const [postForCommentModal, setPFCM] = useState();
  const [posts, setPosts] = useState([]);
  const [open, setOpen] = useState(false);
  const [openCM, setOpenCM] = useState(false);
  const handleOpen = () => setOpen(true);
  const handleOpenCM = () => openCM(true);

  useEffect(() => {
    const CallBack = async () => {
      const getPosts = await api.getAllPost();
      setPosts(getPosts);
    };
    CallBack();
  }, []);

  const handleClose = async () => {
    setOpen(false);
    setOpenCM(false);
    const getPosts = await api.getAllPost();
    setPosts(getPosts);
  };

  const likePost = async (postId) =>{
    const result = await api.likePost(account.accountId, postId)
    console.log(result);
  }
  return (
    <>
      <div className="text-white mt-32 mb-32">
        {account ? (
          <div className="rounded-xl w-5/12 m-auto bg-neutral-800 p-5 mb-10">
            <div className="mb-3 text-xl font-medium">{account?.username}</div>
            <input
              onClick={handleOpen}
              className="rounded-full p-2 w-full bg-neutral-600"
              placeholder={account?.username + " what are you thinking ?"}
            />
          </div>
        ) : (
          ""
        )}
        {posts?.map((post) => (
          <>
            <div
              key={post.postId}
              className="rounded-xl w-5/12 m-auto bg-neutral-800 mb-20"
            >
              <div className="pt-3 mx-5">
                <div className="font-medium">{post?.account?.username}</div>
                <div className="font-light text-neutral-400">
                  {post?.createdDate}
                </div>
              </div>
              <div
                className="my-5 mx-5 pl-2"
                dangerouslySetInnerHTML={{ __html: post?.content }}
              ></div>

              {post?.images ? (
                <div className="my-5 mx-5 pl-2">
                  <PhotoArrageImgUrl urls={post?.images?.split(",")} />
                </div>
              ) : (
                ""
              )}

              <div className="bg-neutral-700 h-1 w-full" />
              <div className="flex justify-between text-neutral-400 mx-10 py-5">
                <div onClick={() => likePost(post.postId)}>
                  <ThumbUpOffAltIcon /> Thích {post.postComments.length>0?post.postComments.length:""}
                </div>
                <div>
                  <ChatBubbleOutlineIcon
                    onClick={() => {
                      setPFCM(post);
                      handleOpenCM();
                    }}
                  />{" "}
                  Bình luận
                </div>
                <div>
                  <SendIcon /> Chia sẻ
                </div>
              </div>
            </div>
          </>
        ))}
      </div>

      {/* modal */}
      <Modal
        open={open}
        onClose={handleClose}
        aria-labelledby="modal-modal-title"
        aria-describedby="modal-modal-description"
      >
        <Box sx={createPostmodalStyle}>
          <CreatePostModal handleClose={handleClose} />
        </Box>
      </Modal>

      <Modal
        open={open}
        onClose={handleClose}
        aria-labelledby="modal-modal-title"
        aria-describedby="modal-modal-description"
      >
        <Box sx={createPostmodalStyle}>
          <CommentModal handleClose={handleClose} Post={postForCommentModal} />
        </Box>
      </Modal>
    </>
  );
};

export default PostList;
