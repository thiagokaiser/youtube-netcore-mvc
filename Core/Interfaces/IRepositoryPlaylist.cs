﻿using Core.Models;
using Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IRepositoryPlaylist
    {
        Task<Playlist> PlaylistById(int id);
        Task<Playlist> PlaylistVideosById(int id);
        Task<IEnumerable<Playlist>> PlaylistList();
        Task RemoveVideoFromPlaylist(VideoPlaylistViewModel videoPlaylist);
        Task PlaylistDel(int id);
        Task PlaylistAdd(Playlist playlist);
        Task PlaylistUpdate(Playlist playlist);

    }
}
