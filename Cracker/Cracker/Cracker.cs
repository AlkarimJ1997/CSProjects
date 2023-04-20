using System.Linq;

namespace Cracker;

public class Cracker
{
    public readonly Dictionary<string, string> Identifiers = new()
    {
        { "", "DES" },
        { "$y$", "yescrypt" },
        { "$gy$", "gost-yescrypt" },
        { "$1$", "MD5" },
        { "$2$", "Blowfish (bcrypt)" },
        { "$2a$", "Blowfish (bcrypt)" },
        { "$2b$", "Blowfish (bcrypt)" },
        { "$2x$", "Blowfish (bcrypt)" },
        { "$2y$", "Blowfish (bcrypt)" },
        { "$3$", "NTHASH" },
        { "$5$", "SHA-256" },
        { "$6$", "SHA-512" },
        { "$7$", "scrypt" },
        { "$md5$", "SunMD5" }
    };

    // Constants
    private const string Alpha = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private const string AlphaNumeric = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    private const string Chars = Alpha + AlphaNumeric + "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";

    // Character Set
    private string _characterSet;

    // Variables
    private string _file;
    private string[] _users;
    private bool _dictAttack;
    private bool _bruteForce;
    private bool _alpha;
    private bool _alphaNum;

    public Cracker(string file, string[] users, bool dictAttack, bool bruteForce, bool alpha, bool alphaNum)
    {
        _file = file;
        _users = users;
        _dictAttack = dictAttack;
        _bruteForce = bruteForce;
        _alpha = alpha;
        _alphaNum = alphaNum;

        DefineCharacterSet(_alpha, _alphaNum);
    }

    public string IdentifyAlgorithm(string identifier) => Identifiers[identifier] ?? "Unknown";

    private void DefineCharacterSet(bool alpha, bool alphaNum)
    {
        if (alpha)
        {
            _characterSet = Alpha;
        }
        else if (alphaNum)
        {
            _characterSet = AlphaNumeric;
        }
        else
        {
            _characterSet = Chars;
        }
    }

    private IEnumerable<string> GeneratePasswords()
    {
        var passwordLengths = Enumerable.Range(1, int.MaxValue);
        var passwordCombinations = passwordLengths.SelectMany(
            length => _characterSet.SelectMany(c => Enumerable.Repeat(c, length)),
            (length, combination) => new string(combination.ToString()));

        return passwordCombinations;
    }

    public void Run()
    {
        foreach (var password in GeneratePasswords())
        {
            Console.WriteLine(password);
        }
    }
}