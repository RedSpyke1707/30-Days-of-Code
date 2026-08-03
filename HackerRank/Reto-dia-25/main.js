function isPrime(n) {
    if (n <= 1) return false;
    if (n <= 3) return true;
    if (n % 2 === 0 || n % 3 === 0) return false;
    
    for (let i = 5; i * i <= n; i += 6) {
        if (n % i === 0 || n % (i + 2) === 0) return false;
    }
    return true;
}

function main() {
    const fs = require('fs');
    const input = fs.readFileSync('/dev/stdin', 'utf-8').trim().split(/\s+/);
    
    if (input.length === 0 || input[0] === '') return;
    
    const t = parseInt(input[0], 10);
    for (let i = 1; i <= t; i++) {
        const n = parseInt(input[i], 10);
        if (isPrime(n)) {
            console.log("Prime");
        } else {
            console.log("Not prime");
        }
    }
}

main();