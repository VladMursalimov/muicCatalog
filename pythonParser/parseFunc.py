import random
from datetime import datetime


def parseTracks(tracks_):
    genres = []
    songs = []
    with open("txts/tracks.txt", "w", encoding='utf-16') as file, open('txts/genres.txt', 'w') as genresf:
        file.write('id;title;album_title;release_date;duration;count_of_views;genre;album_id;url\n')
        for track in tracks_:
            title = track['title']
            id = track["real_id"]
            url = track["cover_uri"].replace("%%", "m100x100")
            if (id not in songs):
                songs.append(id)
                if (track['albums']):
                    album = track['albums'][0]
                    album_title = album['title']
                    album_id = album['id']
                    if (not album['release_date']):
                        release_date = "1970-01-01"
                    else:
                        release_date = album['release_date'][0:10]
                    if (album['genre'] not in genres):
                        genresf.write(f"{len(genres)};{album['genre']}\n")
                        genres.append(album['genre'])
                        genre = album["genre"]
                else:
                    album = None
                    album_title = None
                    album_id = None
                    release_date = "1970-01-01"
                    genre = None
                duration = track['duration_ms'] // 1000
                count_of_views = 0
                file.write(f'{id};{title};{album_title};{release_date};{duration};{count_of_views};{genre};{album_id};{url}\n')



def parseArtists(tracks_):
    artists = []
    with open("txts/artists.txt", "w", encoding="utf-16") as file:
        try:
            file.write('id;name;id_count_of_views;count_of_songs;count_of_albums;url\n')
            for track in tracks_:
                for artist in track["artists"]:
                    name = artist['name']
                    id = artist['id']
                    url = None
                    if (artist['cover']): url = artist['cover']['uri'].replace("%%", "m100x100")
                    if (id not in artists):
                        artists.append(id)
                        id_count_of_views = 0
                        count_of_songs = 0
                        count_of_albums = 0
                        file.write(f'{id};{name};{id_count_of_views};{count_of_songs};{count_of_albums};{url}\n')
        except Exception:
            print(Exception)

def parseAlbums(tracks_):
    albums = []
    with open("txts/albums.txt", "w", encoding="utf-16") as file:
        file.write('album_id;album_title;release_date;duration;track_count;count_of_views;url\n')
        for track in tracks_:
            album = track['albums'][0]
            album_title = album['title']
            album_id = album['id']
            url = album['cover_uri'].replace("%%", "m100x100")
            if (album_id not in albums):
                albums.append(album_id)
                if (not album['release_date']):
                    release_date = "1970-01-01"
                else:
                    release_date = album['release_date'][0:10]
                date = datetime.strptime(release_date, "%Y-%m-%d")
                track_count = album['track_count']
                duration = 0
                count_of_views = 0
                file.write(f'{album_id};{album_title};{release_date};{duration};{track_count};{count_of_views};{url}\n')


def parseArtistsOfSongs(tracks_):
    songs_artists = []
    with open("txts/artists_of_songs.txt", "w", encoding="utf-16") as file:
        file.write("id song;album id;id artist\n")
        for track in tracks_:
            track_id = track['real_id']
            if (track_id not in songs_artists):
                songs_artists.append(track_id)
                if (track['albums']):
                    album = track['albums'][0]
                    album_title = album['title']
                    album_id = album['id']
                else:
                    album = None
                    album_title = None
                    random.seed(datetime.now().timestamp())
                    album_id = int(random.random()*10e6)
                for artist in track['artists']:
                    artist_id = artist["id"]
                    file.write(f'{track_id};{album_id};{artist_id}\n')

