﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using HTTPClient.Services;
using HTTPClient.Models;

namespace HTTPClient.ViewModel
{
    public partial class CreatePostViewModel : ObservableObject
    {
        [ObservableProperty]
        string title;
        [ObservableProperty]
        string body;
        [ObservableProperty]
        int id;
        [ObservableProperty]
        int userId = 1;

        public ICommand SavePostCommand { get; }

        public CreatePostViewModel()
        {
            SavePostCommand = new Command(SavePost);
        }

        public async void SavePost()
        {
            Post post = new Post();
            Post newPost = new Post();
            post.Title = title;
            post.Body = body;
            post.UserId = userId;   

            PostService postService = new PostService();
            newPost = await postService.SavePostAsync(post);
        }

    }
}
