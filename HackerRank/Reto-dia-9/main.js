process.stdin.resume();
process.stdin.setEncoding('utf8');

let inputData = '';
let currentLine = 0;

process.stdin.on('data', data => inputData += data);

process.stdin.on('end', () => {
    inputData = inputData.split('\n');
    main();
});

function readLine() {
    return inputData[currentLine++];
}

function factorial(n) {
    if (n === 0) {
        return 1;
    }
    return n * factorial(n - 1);
}

function main() {
    const n = parseInt(readLine());
    console.log(factorial(n));
}