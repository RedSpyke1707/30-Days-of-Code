process.stdin.resume();
process.stdin.setEncoding('utf8');

let inputData = '';

process.stdin.on('data', data => inputData += data);

process.stdin.on('end', () => {
    const lines = inputData.split('\n');
    const n = parseInt(lines[0]);
    const phoneBook = new Map();
    
    for (let i = 1; i <= n; i++) {
        const [name, number] = lines[i].split(' ');
        phoneBook.set(name, number);
    }
    
    const output = [];
    for (let i = n + 1; i < lines.length; i++) {
        const name = lines[i].trim();
        if (name === '') continue;
        if (phoneBook.has(name)) {
            output.push(`${name}=${phoneBook.get(name)}`);
        } else {
            output.push('Not found');
        }
    }
    console.log(output.join('\n'));
});