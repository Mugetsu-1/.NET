using System;
using System.Reflection;

namespace Lab2
{
    // 1. Define a custom attribute
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property,
                    AllowMultiple = true, Inherited = false)]
    class DeveloperInfoAttribute : Attribute
    {
        public string DeveloperName { get; }
        public string DateCreated { get; }
        public string Description { get; set; } // Named parameter

        public DeveloperInfoAttribute(string developerName, string dateCreated)
        {
            DeveloperName = developerName;
            DateCreated = dateCreated;
            Description = "No description provided";
        }
    }

    // 2. Define another custom attribute for version tracking
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    class VersionAttribute : Attribute
    {
        public int Major { get; }
        public int Minor { get; }
        public int Build { get; }

        public VersionAttribute(int major, int minor, int build)
        {
            Major = major;
            Minor = minor;
            Build = build;
        }

        public string GetVersion() => $"{Major}.{Minor}.{Build}";
    }

    // 3. Define custom attribute for validation
    [AttributeUsage(AttributeTargets.Property)]
    class RangeAttribute : Attribute
    {
        public double Minimum { get; }
        public double Maximum { get; }

        public RangeAttribute(double min, double max)
        {
            Minimum = min;
            Maximum = max;
        }

        public bool IsValid(double value)
        {
            return value >= Minimum && value <= Maximum;
        }
    }

    // 4. Define custom attribute for display purposes
    [AttributeUsage(AttributeTargets.Property)]
    class DisplayNameAttribute : Attribute
    {
        public string DisplayName { get; }

        public DisplayNameAttribute(string displayName)
        {
            DisplayName = displayName;
        }
    }

    // 5. Apply custom attributes
    [DeveloperInfo("Saugat Thapa", "2024-01-15", Description = "Core banking system module")]
    [DeveloperInfo("Alice Sharma", "2024-02-20", Description = "Security review and enhancements")]
    [Version(2, 1, 0)]
    class BankAccount
    {
        [DisplayName("Account Number")]
        public int AccountNumber { get; set; }

        [DisplayName("Account Holder")]
        public string AccountHolder { get; set; }

        [DisplayName("Balance")]
        [Range(0, 1000000)]
        public double Balance { get; set; }

        [DeveloperInfo("Bob Johnson", "2024-03-01", Description = "Added interest rate feature")]
        [DisplayName("Interest Rate")]
        [Range(0, 15)]
        public double InterestRate { get; set; }

        [DeveloperInfo("Bob Johnson", "2024-03-01", Description = "Added interest rate feature")]
        public void CalculateInterest()
        {
            Console.WriteLine("   Calculating interest...");
        }

        [Obsolete("DepositFunds is obsolete, use ProcessDeposit instead")]
        public void DepositFunds(double amount)
        {
            Console.WriteLine($"   Depositing ${amount} (old method)");
        }
    }

    internal class CustomAttributesDemo
    {
        /*
        static void Main(string[] args)
        {
            

            // 1. Reading class-level custom attributes
            Console.WriteLine("1. Reading class-level custom attributes:");
            Type bankAccountType = typeof(BankAccount);

            // Get DeveloperInfo attributes
            var devInfos = bankAccountType.GetCustomAttributes<DeveloperInfoAttribute>();
            Console.WriteLine($"   BankAccount Developer Info:");
            foreach (var devInfo in devInfos)
            {
                Console.WriteLine($"     Developer: {devInfo.DeveloperName}");
                Console.WriteLine($"     Date Created: {devInfo.DateCreated}");
                Console.WriteLine($"     Description: {devInfo.Description}");
                Console.WriteLine();
            }

            // Get Version attribute
            var version = bankAccountType.GetCustomAttribute<VersionAttribute>();
            if (version != null)
            {
                Console.WriteLine($"   Version: {version.GetVersion()}");
                Console.WriteLine($"     Major: {version.Major}");
                Console.WriteLine($"     Minor: {version.Minor}");
                Console.WriteLine($"     Build: {version.Build}");
            }
            Console.WriteLine();

            // 2. Reading property-level custom attributes
            Console.WriteLine("2. Reading property-level custom attributes:");
            var properties = bankAccountType.GetProperties();
            foreach (var prop in properties)
            {
                Console.WriteLine($"   Property: {prop.Name}");

                // Get DisplayName
                var displayName = prop.GetCustomAttribute<DisplayNameAttribute>();
                if (displayName != null)
                    Console.WriteLine($"     Display Name: {displayName.DisplayName}");

                // Get Range validation
                var range = prop.GetCustomAttribute<RangeAttribute>();
                if (range != null)
                    Console.WriteLine($"     Valid Range: {range.Minimum} to {range.Maximum}");

                // Get DeveloperInfo on properties
                var propDevInfos = prop.GetCustomAttributes<DeveloperInfoAttribute>();
                foreach (var devInfo in propDevInfos)
                    Console.WriteLine($"     Developer Info: {devInfo.DeveloperName} ({devInfo.Description})");

                Console.WriteLine();
            }

            // 3. Reading method-level custom attributes
            Console.WriteLine("3. Reading method-level custom attributes:");
            var methods = bankAccountType.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            foreach (var method in methods)
            {
                var methodDevInfos = method.GetCustomAttributes<DeveloperInfoAttribute>();
                foreach (var devInfo in methodDevInfos)
                {
                    Console.WriteLine($"   Method: {method.Name}");
                    Console.WriteLine($"     Developer: {devInfo.DeveloperName}");
                    Console.WriteLine($"     Description: {devInfo.Description}");
                    Console.WriteLine();
                }
            }

            // 4. Using custom attributes for validation
            Console.WriteLine("4. Using custom attributes for validation:");
            BankAccount account = new BankAccount
            {
                AccountNumber = 1001,
                AccountHolder = "Saugat Thapa",
                Balance = 500000,    // Within range (0-1000000)
                InterestRate = 7.5   // Within range (0-15)
            };
            Console.WriteLine($"   Account created: {account.AccountHolder}");

            // Validate using attributes
            Console.WriteLine("   Validation Results:");
            foreach (var prop in typeof(BankAccount).GetProperties())
            {
                var rangeAttr = prop.GetCustomAttribute<RangeAttribute>();
                if (rangeAttr != null)
                {
                    double value = Convert.ToDouble(prop.GetValue(account));
                    bool isValid = rangeAttr.IsValid(value);
                    Console.WriteLine($"     {prop.Name} = {value}: {(isValid ? "PASS" : "FAIL")} (range: {rangeAttr.Minimum}-{rangeAttr.Maximum})");
                }
            }
            Console.WriteLine();

            // 5. Demonstrate validation failure
            Console.WriteLine("5. Validation failure example:");
            BankAccount invalidAccount = new BankAccount
            {
                AccountNumber = 1002,
                AccountHolder = "Test User",
                Balance = 2000000,   // Exceeds max of 1000000
                InterestRate = 20    // Exceeds max of 15
            };
            Console.WriteLine($"   Invalid account created: {invalidAccount.AccountHolder}");
            foreach (var prop in typeof(BankAccount).GetProperties())
            {
                var rangeAttr = prop.GetCustomAttribute<RangeAttribute>();
                if (rangeAttr != null)
                {
                    double value = Convert.ToDouble(prop.GetValue(invalidAccount));
                    bool isValid = rangeAttr.IsValid(value);
                    Console.WriteLine($"     {prop.Name} = {value}: {(isValid ? "PASS" : "FAIL")}");
                }
            }

            Console.WriteLine("\n=== Custom Attributes Demo Complete ===");
        }
        */
    }
}
