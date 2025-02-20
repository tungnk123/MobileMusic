﻿using MobileMusic.usercontrols;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;

namespace MobileMusic
{
    public class DataSource
    {
        string songPath = "D:\\tai-lieu-uit\\nam-3\\C#\\BaiTH2\\MobileMusic\\MobileMusic\\bin\\Debug\\assets\\song\\song.txt";
        string songTypePath = "D:\\tai-lieu-uit\\nam-3\\C#\\BaiTH2\\MobileMusic\\MobileMusic\\bin\\Debug\\assets\\songtype\\songtype.txt";
        string playlistPath = "D:\\tai-lieu-uit\\nam-3\\C#\\BaiTH2\\MobileMusic\\MobileMusic\\bin\\Debug\\assets\\playlist\\playlist.txt";
        string playlistSongPath = "D:\\tai-lieu-uit\\nam-3\\C#\\BaiTH2\\MobileMusic\\MobileMusic\\bin\\Debug\\assets\\playlist-song\\playlist-song.txt";

        public static int countLinePlaylist = 0;
        public static int currentPlaylistId = 0;
        public static int currentMusicId = 0;
        public static DataTable dtRecents = null;
        public static DataTable dtDownload = null;
        public static DataTable dtLove = null;
        public static DataTable dtMusic = null;
        public static DataTable dtPlaylist = null;
        public static DataTable dtSongType = null;
        public static List<string> songList = new List<string>();
        public static List<string> authorList = new List<string>();
        public static Dictionary<int, List<SongInPlayListUC>> map = new Dictionary<int, List<SongInPlayListUC>>();
        public void loadSongIntoDatatable()
        {
            dtMusic = new DataTable();
            dtMusic.Columns.Add("id", typeof(int));
            dtMusic.Columns.Add("image", typeof(Image));
            dtMusic.Columns.Add("music", typeof(string));
            dtMusic.Columns.Add("name", typeof(string));
            dtMusic.Columns.Add("author", typeof(string));
            dtMusic.Columns.Add("isFav", typeof(bool));
            dtMusic.Columns.Add("isPlay", typeof(bool));
            dtMusic.Columns.Add("isSaved", typeof(bool));
            dtMusic.Columns.Add("type", typeof(string));

            StreamReader sr = new StreamReader(songPath);
            string str;
            while ((str = sr.ReadLine()) != null)
            {
                string[] st = str.Split('*');
                Image ava = Image.FromFile(st[1]);
                songList.Add(st[3]);
                authorList.Add(st[4]);
                dtMusic.Rows.Add(st[0], ava, st[2], st[3], st[4], bool.Parse(st[5]), bool.Parse(st[6]), bool.Parse(st[7]), st[8]);

            }
            sr.Close();

        }

        public void saveSongFromDatatableToFile()
        {
            using (StreamWriter sw = new StreamWriter(songPath))
            {
                foreach (DataRow row in dtMusic.Rows)
                {
                    sw.WriteLine(row["id"] + "*assets\\image\\" + row["id"] + ".png*" + row["music"] + "*" + row["name"] + "*" + row["author"] + "*" + row["isFav"] + "*" + row["isPlay"] + "*" + row["isSaved"] + "*" + row["type"]);
                }
            }
        }


        public void saveSongTypeIntoDatatable()
        {
            dtSongType = new DataTable();
            dtSongType.Columns.Add("id", typeof(int));
            dtSongType.Columns.Add("name", typeof(string));
            dtSongType.Columns.Add("count", typeof(int));

            StreamReader sr = new StreamReader(songTypePath);
            string str;
            while ((str = sr.ReadLine()) != null)
            {
                string[] st = str.Split('*');

                dtSongType.Rows.Add(Int32.Parse(st[0]), st[1], Int32.Parse(st[2]));

            }
            sr.Close();
        }

        public void loadRecentIntoDatatable()
        {
            dtRecents = new DataTable();
            dtRecents.Columns.Add("id", typeof(int));
            dtRecents.Columns.Add("image", typeof(Image));
            dtRecents.Columns.Add("title", typeof(string));

            StreamReader sr = new StreamReader(songPath);
            string str;
            while ((str = sr.ReadLine()) != null)
            {
                string[] st = str.Split('*');
                if (st[6] == "True")
                {
                    Image ava = Image.FromFile(st[1]);
                    dtRecents.Rows.Add(Int32.Parse(st[0]), ava, st[3]);
                }
            }
            sr.Close();

        }
        public void loadDownloadIntoDatatable()
        {
            dtDownload = new DataTable();
            dtDownload.Columns.Add("id", typeof(int));
            dtDownload.Columns.Add("image", typeof(Image));
            dtDownload.Columns.Add("title", typeof(string));

            StreamReader sr = new StreamReader(songPath);
            string str;
            while ((str = sr.ReadLine()) != null)
            {
                string[] st = str.Split('*');
                if (st[7] == "True")
                {
                    Image ava = Image.FromFile(st[1]);
                    dtDownload.Rows.Add(Int32.Parse(st[0]), ava, st[3]);
                }
            }
            sr.Close();

        }

        public void loadLoveIntoDatatable()
        {
            dtLove = new DataTable();
            dtLove.Columns.Add("id", typeof(int));
            dtLove.Columns.Add("image", typeof(Image));
            dtLove.Columns.Add("music", typeof(string));
            dtLove.Columns.Add("name", typeof(string));
            dtLove.Columns.Add("author", typeof(string));
            dtLove.Columns.Add("isPlay", typeof(bool));
            dtLove.Columns.Add("isSaved", typeof(bool));

            StreamReader sr = new StreamReader(songPath);
            string str;
            while ((str = sr.ReadLine()) != null)
            {
                string[] st = str.Split('*');
                if (st[5] == "True")
                {
                    Image ava = Image.FromFile(st[1]);
                    dtLove.Rows.Add(st[0], ava, st[2], st[3], st[4], bool.Parse(st[6]), bool.Parse(st[7]));
                }
            }
            sr.Close();
        }

        public void savePlayListFromDatatableToFile()
        {
            using (StreamWriter sw = new StreamWriter(playlistPath))
            {
                foreach (DataRow row in dtPlaylist.Rows)
                {
                    sw.WriteLine(row["id"] + "*" + row["title"] + "*" + row["count"] + "*" + row["isDeleted"]);
                }
            }
        }

        public void loadPlayListIntoDatatable()
        {
            int count = 0;
            dtPlaylist = new DataTable();
            dtPlaylist.Columns.Add("id", typeof(int));
            dtPlaylist.Columns.Add("title", typeof(string));
            dtPlaylist.Columns.Add("count", typeof(int));
            dtPlaylist.Columns.Add("isDeleted", typeof(bool));

            StreamReader sr = new StreamReader(playlistPath);
            string str;
            while ((str = sr.ReadLine()) != null)
            {
                count++;
                string[] st = str.Split('*');
                dtPlaylist.Rows.Add(Int32.Parse(st[0]), st[1], Int32.Parse(st[2]), bool.Parse(st[3]));
            }
            sr.Close();
            countLinePlaylist = count;
        }

        public void loadPlaylistSongIntoMap()
        {
            map.Clear();
            StreamReader sr = new StreamReader(playlistSongPath);
            string str;
            while ((str = sr.ReadLine()) != null)
            {
                string[] st = str.Split('*');
                int playlistId = Int32.Parse(st[0]);
                int songId = Int32.Parse(st[1]);
                bool isDeleted = bool.Parse(st[2]);
                if (!isDeleted)
                {
                    SongInPlayListUC musicItemUC = new SongInPlayListUC();
                    musicItemUC.loadDataIntoMusicItemUc(
                        (int)DataSource.dtMusic.Rows[songId]["id"] - 1
                        , (Image)DataSource.dtMusic.Rows[songId]["image"]
                        , (string)DataSource.dtMusic.Rows[songId]["music"]
                        , (string)DataSource.dtMusic.Rows[songId]["name"]
                        , (string)DataSource.dtMusic.Rows[songId]["author"]
                        , (bool)DataSource.dtMusic.Rows[songId]["isFav"]
                        , (bool)DataSource.dtMusic.Rows[songId]["isPlay"]
                        , (bool)DataSource.dtMusic.Rows[songId]["isSaved"]
                        , (string)DataSource.dtMusic.Rows[songId]["type"]
                        , isDeleted);
                    if (!map.ContainsKey(playlistId))
                    {
                        map[playlistId] = new List<SongInPlayListUC>();
                    }
                    map[playlistId].Add(musicItemUC);
                }

            }
            sr.Close();
        }

        public void savePlaylistSongFromMapIntoFile()
        {
            using (StreamWriter sw = new StreamWriter(playlistSongPath))
            {
                foreach (int key in map.Keys)
                {
                    foreach (SongInPlayListUC value in map[key])
                    {
                        sw.WriteLine(key + "*" + value.id + "*" + value.isDeleted);
                    }

                }
            }
        }


    }


}
