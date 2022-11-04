import Constants from "../constants";

export default function Line(props: { word: string | null, current: boolean, correctWord: string, badWord: boolean }) {
    const letters = Array<string>(Constants.WORD_LENGTH);
    if (props.word) {
        for (let i = 0; i < props.word.length; ++i)
            letters[i] = props.word[i];
        for (let i = props.word.length; i < Constants.WORD_LENGTH; ++i)
            letters[i] = ' ';
    } else letters.fill(' ');
    return <div className={"line" + (props.badWord ? ' badWordLine' : '')}>{
        letters.map((letter, i) => {
            const additionClass = props.current
                ? props.badWord
                    ? null
                    : "currentLine"
                : props.correctWord[i] == letter
                    ? 'correctLetter'
                    : props.correctWord.indexOf(letter) > -1
                        ? 'letterInIncorrectPosition'
                        : null;
            return <div className={"letterSquare" + (additionClass ? ' ' + additionClass : '')}>{letter}</div>;
        })
    }
    </div>
}
