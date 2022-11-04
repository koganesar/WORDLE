import React, {useEffect, useState} from 'react';
import './App.css';
import Line from './components/line';
import Word from './interfaces/word'
import Constants from "./constants";

function App() {
    const [theWord, setTheWord] = useState({self: '', id: 0} as Word);
    const [words, setWords] = useState(Array<Word>(0));
    const [guesses, setGuesses] = useState(Array<string | null>(Constants.WORDS_COUNT).fill(null));
    const [currentGuessNumber, setCurrenGuessNumber] = useState(0);
    const [badWord, setBadWord] = useState(false);
    const [gameOver, setGameOver] = useState(false);

    //fetching words
    useEffect(() => {
        const fetchWords = async () => {
            const response = await fetch(Constants.WORDS_URL);
            const words: Word[] = await response.json();
            const theWord = words[Math.floor(Math.random() * words.length)];
            console.log(`the word is + '${theWord.self}'`)
            setTheWord(theWord);
            setWords(words);
        };
        fetchWords();
    }, []);

    //keyboard input
    useEffect(() => {
        const handleGuessWrote = (guesses: Array<string | null>) => {
            const writtenGuess = guesses[currentGuessNumber];
            if (writtenGuess == theWord.self)
                console.log(`solved: '${writtenGuess}'`);
            if (!words.find(word => word.self == writtenGuess)) {
                console.log(`bad word: '${writtenGuess}'`);
                setBadWord(true);
            } else {
                console.log(`incorrect: '${writtenGuess}'`);
                setCurrenGuessNumber(prevState => prevState + 1);
            }

            if (currentGuessNumber > 4) {
                console.log(`game over`);
                setGameOver(true);
            }
        }

        const handleKeydown = (e: KeyboardEvent) => {
            if (gameOver)
                return;
            if (e.key == 'Backspace') {
                setBadWord(false);
                setGuesses(prevState => {
                    const guesses = [...prevState];
                    let currentGuess = guesses[currentGuessNumber];
                    currentGuess = currentGuess?.slice(0, currentGuess?.length - 1) ?? null;
                    guesses[currentGuessNumber] = currentGuess;
                    return guesses;
                });
                return;
            }
            const key = e.key.toUpperCase();
            if (key.length == 1 && key >= 'A' && key <= 'Z') {
                setGuesses(prevState => {
                    const guesses = [...prevState];
                    let currentGuess = badWord ? '' : guesses[currentGuessNumber];
                    if (!currentGuess) {
                        guesses[currentGuessNumber] = key;
                        return guesses;
                    }
                    currentGuess += key;
                    guesses[currentGuessNumber] = currentGuess;
                    if (currentGuess.length == Constants.WORD_LENGTH) {
                        handleGuessWrote(guesses);
                    }
                    return guesses;
                });
                setBadWord(false);
            }
        };

        document.addEventListener('keydown', handleKeydown);

        return () => document.removeEventListener('keydown', handleKeydown);
    }, [currentGuessNumber, setCurrenGuessNumber, guesses, setGuesses, theWord, words, gameOver, setGameOver])

    return (
        <div className="App">
            <header className="App-header">
                <div className="lines">
                    {guesses.map((word, i) => {
                        const currentLine = i == currentGuessNumber;
                        return <Line word={word}
                                     current={currentLine}
                                     correctWord={theWord.self}
                                     badWord={currentLine && badWord}/>
                    })}
                </div>
            </header>
        </div>
    );
}

export default App;
