import random

from yandex_music import Client
import parseFunc as pf
from datetime import datetime


apiToken = "y0_AgAAAAAPGffHAAG8XgAAAAEAU8xQAAA5hfjIZPRLn69oixaHXcu-W8s4rg"

client = Client(apiToken).init()
tracks = client.users_likes_tracks().fetch_tracks()[5:20]

pf.parseTracks(tracks)
pf.parseAlbums(tracks)
pf.parseArtists(tracks)
pf.parseArtistsOfSongs(tracks)