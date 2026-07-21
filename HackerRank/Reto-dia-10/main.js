process.stdin.resume();
process.stdin.setEncoding('utf8');

let inputData = '';

process.stdin.on('data', data => inputData += data);

process.stdin.on('end', () => {
    const n = parseInt(inputData.trim());
    const binary = n.toString(2); // convierte n a string binario
    
    let maxCount = 0;
    let currentCount = 0;
    
    for (const bit of binary) {
        if (bit === '1') {
            currentCount++;
            maxCount = Math.max(maxCount, currentCount);
        } else {
            currentCount = 0;
        }
    }
    
    console.log(maxCount);
});