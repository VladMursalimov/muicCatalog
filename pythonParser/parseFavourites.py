import random

from yandex_music import Client
import parseFunc as pf
from datetime import datetime

#place here your api token
apiToken = ""

client = Client(apiToken).init()
tracks = client.users_likes_tracks().fetch_tracks()[5:20]

pf.parseTracks(tracks)
pf.parseAlbums(tracks)
pf.parseArtists(tracks)
pf.parseArtistsOfSongs(tracks)