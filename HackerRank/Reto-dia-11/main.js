process.stdin.resume();
process.stdin.setEncoding('utf8');

let inputData = '';

process.stdin.on('data', data => inputData += data);

process.stdin.on('end', () => {
    const lines = inputData.split('\n');
    const arr = [];
    
    for (let i = 0; i < 6; i++) {
        arr.push(lines[i].split(' ').map(Number));
    }
    
    let maxSum = -Infinity;
    
    for (let i = 0; i < 4; i++) {
        for (let j = 0; j < 4; j++) {
            const currentSum = 
                arr[i][j] + arr[i][j+1] + arr[i][j+2] +
                arr[i+1][j+1] +
                arr[i+2][j] + arr[i+2][j+1] + arr[i+2][j+2];
            maxSum = Math.max(maxSum, currentSum);
        }
    }
    
    console.log(maxSum);
});