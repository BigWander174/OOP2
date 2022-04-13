using System;

namespace OOP
{
    class Expression
    {
        private double _a;
        private double _b;
        private double _c;

        private void SetNormalValues()
        {
            _a = 0;
            _b = 0;
            _c = 0;
        }

        public double D => _b * _b - 4 * _a * _c;

        public void Set(string a, string b, string c)
        {
            try
            {
                _a = Convert.ToDouble(a);
                _b = Convert.ToDouble(b);
                _c = Convert.ToDouble(c);
            }
            catch
            {
                SetNormalValues();
            }
        }

        public string Work()
        {
            if (_a == 0)
            {
                return "Введены неверные данные";
            }
            if (D < 0)
            {
                return "Действительных корней нет";
            }
            else if (D == 0)
            {
                var x = (-_b / (2 * _a));
                return $"X = {x}";
            }
            else
            {
                var x1 = Math.Round((-_b + Math.Sqrt(D)) / (2 * _a), 3);
                var x2 = Math.Round((-_b - Math.Sqrt(D)) / (2 * _a), 3);

                return $"X1 = {x1}, X2 = {x2}";
            }
        }

        public string GetInfo()
        {
            return $"A={_a}, B={_b}, C={_c} {Work()}";
        }
    }
}
