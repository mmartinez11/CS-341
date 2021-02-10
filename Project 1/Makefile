build: main.o characterParser.o charIterator.o acronymIterator.o
	g++ main.o characterParser.o charIterator.o acronymIterator.o -o build

main.o: main.cpp
	g++ -c main.cpp

characterParser.o: characterParser.cpp characterParser.h
	g++ -c characterParser.cpp

charIterator.o: charIterator.cpp charIterator.h
	g++ -c charIterator.cpp

acronymIterator.o: acronymIterator.cpp acronymIterator.h
	g++ -c acronymIterator.cpp

run:
	./build 

clean: 
	rm *.o build