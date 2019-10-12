﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DTO
{
    public class Post
    {
        private string iduser;
        private string idpost;
        private string content;
        private string time;
        private Bitmap image;
        private string name;
        private int liked;

        public string Iduser { get => iduser; set => iduser = value; }
        public string Idpost { get => idpost; set => idpost = value; }
        public string Content { get => content; set => content = value; }
        public string Time { get => time; set => time = value; }
        public Bitmap Image { get => image; set => image = value; }
        public int Liked { get => liked; set => liked = value; }
        public string Name { get => name; set => name = value; }

        public Post()
        {
            Idpost = Iduser = content = "";
            Liked = 0;
            Image = null;
            Time = "";
        }
    }
}
