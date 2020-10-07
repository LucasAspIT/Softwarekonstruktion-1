CREATE TABLE [dbo].[Film] (
    [ID]       INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
    [FilmName] VARCHAR (255) NULL,
    [Year]     INT           NULL,
    [Genre]    VARCHAR (100) NULL,
    [Director] VARCHAR (100) NULL,
    [Actors]   VARCHAR (255) NULL,
);

INSERT INTO 
	Film (FilmName, Year, Genre, Director, Actors)
VALUES
	('The Matrix', 1999, 'Action, Sci-Fi', 'Lana Wachowski, Lilly Wachowski', 'Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss');
	
INSERT INTO 
	Film (FilmName, Year, Genre, Director, Actors)
VALUES
	('The Silence of the Lambs', 1991, 'Crime, Drama, Thriller', 'Jonathan Demme', 'Jodie Foster, Anthony Hopkins, Lawrence A. Bonney');

INSERT INTO 
	Film (FilmName, Year, Genre, Director, Actors)
VALUES
	('Gladiator', 2000, 'Action, Adventure, Drama', 'Ridley Scott', 'Russell Crowe, Joaquin Phoenix, Connie Nielsen');

INSERT INTO 
	Film (FilmName, Year, Genre, Director, Actors)
VALUES
	('Saving Private Ryan', 1998, 'Drama, War', 'Steven Spielberg', 'Tom Hanks, Matt Damon, Tom Sizemore');

INSERT INTO 
	Film (FilmName, Year, Genre, Director, Actors)
VALUES
	('Raiders of the Lost Ark', 1981, 'Action, Adventure', 'Steven Spielberg', 'Harrison Ford, Karen Allen, Paul Freeman');

INSERT INTO 
	Film (FilmName, Year, Genre, Director, Actors)
VALUES
	('Jaws', 1975, 'Adventure, Thriller', 'Steven Spielberg', 'Roy Scheider, Robert Shaw, Richard Dreyfuss');

INSERT INTO 
	Film (FilmName, Year, Genre, Director, Actors)
VALUES
	('Dances with Wolves', 1990, 'Adventure, Drama, Western', 'Kevin Costner', 'Kevin Costner, Mary McDonnell, Graham Greene');

INSERT INTO 
	Film (FilmName, Year, Genre, Director, Actors)
VALUES
	('Jurassic Park', 1993, 'Action, Adventure, Sci-Fi', 'Steven Spielberg', 'Sam Neill, Laura Dern, Jeff Goldblum');

INSERT INTO 
	Film (FilmName, Year, Genre, Director, Actors)
VALUES
	('Pulp Fiction', 1994, 'Crime, Drama', 'Quentin Tarantino', 'John Travolta, Uma Thurman. Samuel L. Jackson');

INSERT INTO 
	Film (FilmName, Year, Genre, Director, Actors)
VALUES
	('Good Will Hunting', 1997, 'Drama, Romance', 'Gus Van Sant', 'Robin Williams, Matt Damon, Ben Affleck');

INSERT INTO 
	Film (FilmName, Year, Genre, Director, Actors)
VALUES
	('Back to the Future', 1985, 'Adventure, Comedy, Sci-Fi', 'Robert Zemeckis', 'Michael J. Fox, Christopher Lloyd, Lea Thompson');

INSERT INTO 
	Film (FilmName, Year, Genre, Director, Actors)
VALUES
	('The Shining', 1980, 'Drama, Horror', 'Stephen King', 'Jack Nicholson, Shelley Duvall, Danny Lloyd');

INSERT INTO 
	Film (FilmName, Year, Genre, Director, Actors)
VALUES
	('Fight Club', 1999, 'Drama', 'David Fincher', 'Brad Pitt, Edward Norton, Meat Loaf');

INSERT INTO 
	Film (FilmName, Year, Genre, Director, Actors)
VALUES
	('Alien', 1979, 'Horror, Sci-Fi', 'Ridley Scott', 'Sigourney Weaver, Tom Skerritt, John Hurt');

INSERT INTO 
	Film (FilmName, Year, Genre, Director, Actors)
VALUES
	('The Big Lebowski', 1998, 'Comedy, Crime, Sport', 'Joel Coen, Ethan Coen', 'Jeff Bridges, John Goodman, Julianne Moore');
	
