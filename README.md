# myIMDb

Swagger: https://localhost:44358/swagger/index.html
EndPoints:
(1)MOVIE
  
    (i)POST-/api/Movie: Add Movie without actor details
    Sample input:{"name": "Movie1",
  "yearOfRelease": "2022-06-29T08:03:14.088Z",
  "plot": "This is a movie about...",
  "poster": "http..",
  "actorIds": [
    0
  ],
  "producer_id": 1
  }
  (ii)POST-/api/Movie/add-movie-with-actors: Add Movie with actor details
  Sample input:{
  "name": "Movie1",
  "yearOfRelease": "2022-06-29T08:05:34.910Z",
  "plot": "This is a movie about...",
  "poster": "http..",
  "actorIds": [
    1,2,3
  ],
  "producer_id": 2
   }
    
    (iii)GET-/api/Movie/get-all-movies:Get all movies
    Sample Output:{
    "id": 1,
    "name": "Batman                                            ",
    "yearOfRelease": "1905-07-16T00:00:00",
    "plot": "aaaaaa",
    "poster": "aaaaaa",
    "actorNames": [
      "Actor1                                            ",
      "Actor2                                            "
    ],
    "producerName": "Prod1"
  },
  {
    "id": 2,
    "name": "Welcome                                           ",
    "yearOfRelease": "2022-06-29T07:13:34.703",
    "plot": "string",
    "poster": "string",
    "actorNames": [
		
      "Actor2                                            ",
      "Actor3                                            "
    ],
    "producerName": "Prod2"
  },
  {
    "id": 3,
    "name": "Dr.Strange                                        ",
    "yearOfRelease": "1905-07-14T00:00:00",
    "plot": "aaaaaaa",
    "poster": "aaaaaaaa",
    "actorNames": [
		
      "Actor1                                            "
    ],
    "producerName": "Prod3"
  }]
  
	(iv)GET-/api/Movie/get-movie-by-id/{id}:Get movie by Id
	Sample input:1
	Sample output:{
  "id": 1,
  "name": "Batman                                            ",
  "yearOfRelease": "1905-07-16T00:00:00",
  "plot": "aaaaaa",
  "poster": "aaaaaa",
  "actorNames": [
	
    "Actor1                                            ",
    "Actor2                                            "
  ],
  "producerName": "Prod1"
   }

   (v)PUT-/api/Movie/update-movie-by-id/{id}:Update Movie
	 Sample input:
	 id:2
	 {
  "name": "Movie2",
  "yearOfRelease": "2022-06-29T08:18:58.717Z",
  "plot": "This movie is a fiction..",
  "poster": "http..",
  "actorIds": [
    4,5
  ],
  "producer_id": 3
   }

	 (vi)DELETE-/api/Movie/delete-movie-by-id/{id}
	 Sample input: id:2
	 (Movie with id=2 will be deleted)
  
	
(2)PRODUCER
     (i)POST-/api/Producer
          Sample Input:{
  "name": "Producer1",
  "sex": "Male",
  "dob": "2022-06-29T07:53:20.705Z",
  "bio": "Produced Movie1"
		}
		
		(ii)GET-/api/Actor/get-all-producers
		[
  {
    "id": 1,
    "name": "Prod1",
    "sex": "Male      ",
    "dob": "1997-07-07T00:00:00",
    "bio": "aaaaaa",
    "movies": null
  },
  {
    "id": 2,
    "name": "Prod2",
    "sex": "Female    ",
    "dob": "1997-09-09T00:00:00",
    "bio": "bbbbbbb",
    "movies": null
  },
  {
    "id": 3,
    "name": "Prod3",
    "sex": "Male      ",
    "dob": "1997-06-06T00:00:00",
    "bio": "cccccccc",
    "movies": null
  }
]
		 (iii)DELET-/api/Produer/delete-producer-by-id/{id}
		 	 Sample input: id:3
	 		 (Movie with id=3 will be deleted)
		 
		 
(3)ACTOR
     (i)POST-/api/Actor
          Sample Input:{
  "name": "Actor1",
  "sex": "Male",
  "dob": "2022-06-29T07:53:20.705Z",
  "bio": "Lead in Movie1"
		}
		
		(ii)GET-/api/Actor/get-all-actor
		[
  {
    "id": 4,
    "name": "Actor1                                            ",
    "sex": "Male      ",
    "dob": "2022-06-29T00:00:00",
    "bio": "aaaaaaaaaa",
    "movieCasts": null
  },
  {
    "id": 5,
    "name": "Actor2                                            ",
    "sex": "Male      ",
    "dob": "2022-06-29T00:00:00",
    "bio": "bbbbbbbbb",
    "movieCasts": null
  },
  {
    "id": 6,
    "name": "Actor3                                            ",
    "sex": "Female    ",
    "dob": "2022-06-28T00:00:00",
    "bio": "ccccccccc",
    "movieCasts": null
  }]
     
		 (iii)DELET-/api/Actor/delete-actor-by-id/{id}
		 	 Sample input: id:4
	 		 (Movie with id=4 will be deleted)
		 
  
