int n = int.Parse(Console.ReadLine());
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();
        
        for (int i = 0; i < n; i++) {
            string[] parts = Console.ReadLine().Split(' ');
            phoneBook[parts[0]] = parts[1];
        }
        
        string name;
        while ((name = Console.ReadLine()) != null) {
            if (phoneBook.ContainsKey(name)) {
                Console.WriteLine($"{name}={phoneBook[name]}");
            } else {
                Console.WriteLine("Not found");
            }
        }