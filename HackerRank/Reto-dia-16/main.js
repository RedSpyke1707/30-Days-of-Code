process.stdin.resume();
process.stdin.setEncoding('utf8');

let inputData = '';
process.stdin.on('data', data => inputData += data);

process.stdin.on('end', () => {
    const S = inputData.trim();
    
    try {
        const num = BigInt(S);
        console.log(num.toString());
    } catch (e) {
        console.log("Bad String");
    }
});