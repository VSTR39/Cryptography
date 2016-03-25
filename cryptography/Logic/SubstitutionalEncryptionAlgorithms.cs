using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cryptography.Logic
{
    class SubstitutionalEncryptionAlgorithms
    {
        string message;

        public SubstitutionalEncryptionAlgorithms(string _message)
        {
            message = _message;
        }

        public string CaesarsCipherEncrypt()
        {
            return _CaesarsCipherEncrypt();
        }
        private string _CaesarsCipherEncrypt()
        {
            char[] array = {'А','Б','В','Г','Д','Е','Ж','З','И','Й','К','Л','М','Н','О','П','Р',
                           'С','Т','У','Ф','Х','Ц','Ч','Ш','Щ','Ъ','Ь','Ю','Я','а','б','в','г',
                           'д','е','ж','з','и','й','к','л','м','н','о','п','р','с','т','у','ф',
                           'х','ц','ч','ш','щ','ъ','ь','ю','я','A','B','C','D','E','F','G','H','I',
                           'J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z',
                           'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q',
                           'r','s','t','u','v','w','x','y','z','0','1','2','3','4','5','6','7',
                           '8','9',' ','.',',',':','/'};

            int message_length = message.Length;
            int length = array.Length;
            int i = 0, j = 0;
            string encr_message = "";
            for (i = 0; i < message_length; i++)
            {
                for (j = 0; j < length; j++)
                {
                    if (message[i] == array[j])
                    {
                        encr_message = encr_message + array[j + 3];
                        break;
                    }
                }
            }

            return encr_message;
        }

        public string CaesarsCipherDecrypt()
        {
            return _CaesarsCipherDecrypt();
        }
        private string _CaesarsCipherDecrypt()
        {
            char[] array = {'А','Б','В','Г','Д','Е','Ж','З','И','Й','К','Л','М','Н','О','П','Р',
                           'С','Т','У','Ф','Х','Ц','Ч','Ш','Щ','Ъ','Ь','Ю','Я','а','б','в','г',
                           'д','е','ж','з','и','й','к','л','м','н','о','п','р','с','т','у','ф',
                           'х','ц','ч','ш','щ','ъ','ь','ю','я','A','B','C','D','E','F','G','H','I',
                           'J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z',
                           'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q',
                           'r','s','t','u','v','w','x','y','z','0','1','2','3','4','5','6','7',
                           '8','9',' ','.',',',':','/'};

            int message_length = message.Length;
            int length = array.Length;
            int i = 0, j = 0;
            string decr_message = "";
            for (i = 0; i < message_length; i++)
            {
                for (j = 0; j < length; j++)
                {
                    int x = j - 3;
                    if (x < 0) x = x + length;
                    if (message[i] == array[j])
                    {
                        decr_message = decr_message + array[x];
                        break;
                    }
                }
            }

            return decr_message;
        }

        public string DirectSubstitutionEncrypt(bool spaceEncrypting)
        {
            return _DirectSubstitutionEncrypt(spaceEncrypting);
        }
        private string _DirectSubstitutionEncrypt(bool spaceEncrypting)
        {
            char[] M = {' ','А','Б','В','Г','Д','Е','Ж','З','И','Й','К','Л','М','Н','О','П','Р',
                        'С','Т','У','Ф','Х','Ц','Ч','Ш','Щ','Ъ','Ь','Ю','Я','а','б','в','г',
                           'д','е','ж','з','и','й','к','л','м','н','о','п','р','с','т','у','ф',
                           'х','ц','ч','ш','щ','ъ','ь','ю','я','0','1','2','3',
                        '4','5','6','7','8','9','.','-','#','U','S','D','N','Y' ,'"' };

            string[] N = {"35","1","2","3","4","5","6","Ж","З","7","Й","8","9","10","11","12","13","14",
                        "15","16","17","18","19","Ц","Ч","Ш","Щ","38","ь","Ю","20","1","2","3","4",
                           "5","6","ж","з","7","й","8","9","10","11","12","13","14","15","16","17","18",
                           "19","ц","ч","ш","щ","38","ю","20","21","22","23","24",
                        "25","26","27","28","29","30",".","37","#","33","40","34","31","32","39" };

            int message_length = message.Length;
            int length = M.Length;
            int i = 0, j = 0;

            string encr_message = "";

            bool flag_unassigned_symbol = false;
            if (spaceEncrypting)
            {
                for (i = 0; i < message_length; i++)
                {
                    for (j = 0; j < length; j++)
                    {
                        if (message[i] == M[j])
                        {
                            encr_message = encr_message + N[j] + " ";
                            flag_unassigned_symbol = false;
                            break;
                        }
                        else flag_unassigned_symbol = true;

                    }
                    if (flag_unassigned_symbol) encr_message = encr_message + message[i] + " ";
                }

                if (encr_message[encr_message.Length - 1] == '#') ;
                else encr_message = encr_message + '#';

            }
            else
            {
                for (i = 0; i < message_length; i++)
                {
                    for (j = 1; j < length; j++)
                    {
                        if (message[i] == M[j])
                        {
                            encr_message = encr_message + N[j] + " ";
                            flag_unassigned_symbol = false;
                            break;
                        }
                        else flag_unassigned_symbol = true;

                    }
                    if (flag_unassigned_symbol && message[i] != ' ') encr_message = encr_message + message[i] + " ";
                }

                if (encr_message[encr_message.Length - 1] == '#') ;
                else encr_message = encr_message + '#';
            }


            return encr_message;
        }

        public string DirectSubstitutionDecrypt()
        {
            return _DirectSubstitutionDecrypt();
        }
        private string _DirectSubstitutionDecrypt()
        {
            char[] M = {' ','А','Б','В','Г','Д','Е','Ж','З','И','Й','К','Л','М','Н','О','П','Р',
                        'С','Т','У','Ф','Х','Ц','Ч','Ш','Щ','Ъ','Ь','Ю','Я','а','б','в','г',
                           'д','е','ж','з','и','й','к','л','м','н','о','п','р','с','т','у','ф',
                           'х','ц','ч','ш','щ','ъ','ь','ю','я','0','1','2','3',
                        '4','5','6','7','8','9','.','-','#','U','S','D','N','Y' ,'"' };
            string[] N = {"35","1","2","3","4","5","6","Ж","З","7","Й","8","9","10","11","12","13","14",
                        "15","16","17","18","19","Ц","Ч","Ш","Щ","38","ь","Ю","20","1","2","3","4",
                           "5","6","ж","з","7","й","8","9","10","11","12","13","14","15","16","17","18",
                           "19","ц","ч","ш","щ","38","ю","20","21","22","23","24",
                        "25","26","27","28","29","30",".","37","#","33","40","34","31","32","39" };

            int message_length = message.Length;
            int length = M.Length;
            int i = 0, j = 0;
            string temp = "";
            string decr_message = "";


            for (i = 0; i < message_length; i++)
            {
                if (!char.IsDigit(message[i])) decr_message = decr_message + message[i];
                while (message[i] != ' ' && char.IsDigit(message[i]))
                {
                    if (i == message_length - 1) break;
                    temp = temp + message[i];
                    i++;
                }
                for (j = 0; j < length; j++)
                {
                    if (temp == N[j])
                    {
                        decr_message = decr_message + M[j];
                        temp = "";

                        break;
                    }

                }

            }

            return decr_message;
        }



        private int[] findIndexValues(string str, char[] arr)
        {
            int i = 0, j = 0;
            int[] indexes = new int[str.Length];
            for (i = 0; i < str.Length; i++)
            {
                for (j = 0; j < arr.Length; j++)
                {
                    if (char.IsLetter(str[i]) && char.IsLower(str[i]) && (char.ToUpper(str[i]) == arr[j]))
                    {
                        indexes[i] = j;
                        break;
                    }
                    else if (str[i] == arr[j])
                    {
                        indexes[i] = j;
                        break;
                    }
                }
            }
            return indexes;
        }

        public string MultiAlphabeticalSubstitutionEncrypt(string key)
        {
            return _MultiAlphabeticalSubstitutionEncrypt(key);
        }

        private string _MultiAlphabeticalSubstitutionEncrypt(string key)
        {
            char[] array = {'А','Б','В','Г','Д','Е','Ж','З','И','Й','К','Л','М','Н','О','П','Р',
                           'С','Т','У','Ф','Х','Ц','Ч','Ш','Щ','Ъ','Ь','Ю','Я','A','B','C','D','E','F','G','H','I',
                           'J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z','0','1','2','3','4','5','6','7',
                           '8','9',' ','"','-','*'
                           };

            int i = 0, j = 0;
            int[] key_indexes = new int[key.Length];
            int[] message_indexes = new int[message.Length];
            string encr_message = "";
            key_indexes = findIndexValues(key, array);
            message_indexes = findIndexValues(message, array);
            for (i = 0; i < message.Length; i++)
            {

                encr_message = encr_message + array[((message_indexes[i] + key_indexes[i % key.Length]) + 1) % array.Length];


            }
            return encr_message;
        }

        public string MultiAlphabeticalSubstitutionDecrypt(string key)
        {
            return _MultiAlphabeticalSubstitutionDecrypt(key);
        }

        private string _MultiAlphabeticalSubstitutionDecrypt(string key)
        {
            char[] array = {'А','Б','В','Г','Д','Е','Ж','З','И','Й','К','Л','М','Н','О','П','Р',
                           'С','Т','У','Ф','Х','Ц','Ч','Ш','Щ','Ъ','Ь','Ю','Я','A','B','C','D','E','F','G','H','I',
                           'J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z','0','1','2','3','4','5','6','7',
                           '8','9',' ','"','-','*'
                           };


            int i = 0, j = 0;
            int[] key_indexes = new int[key.Length];
            int[] message_indexes = new int[message.Length];
            string decr_message = "";
            key_indexes = findIndexValues(key, array);
            message_indexes = findIndexValues(message, array);

            for (i = 0; i < message.Length; i++)
            {

                decr_message = decr_message + array[(((message_indexes[i] + array.Length) - key_indexes[i % key.Length]) - 1) % array.Length];
            }

            return decr_message;
        }

        private int findIndex(char ch, char[] arr)
        {
            int index = 0;
            int i = 0;
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] == ch) index = i;
            }

            return index;
        }

        private char[,] formEncodingMatrix(char[] array, string str)
        {
            ;
            int i = 0, j = 0, index;
            char[,] resultMatrix = new char[str.Length + 1, array.Length];
            for (i = 0; i < str.Length + 1; i++)
            {


                if (i == 0)
                {
                    for (j = 0; j < array.Length; j++)
                    {
                        resultMatrix[i, j] = array[j];
                    }

                }
                else
                {
                    index = findIndex(str[i - 1], array);
                    for (j = 0; j < index; j++)
                    {
                        resultMatrix[i, (j + (array.Length - index))] = array[j];

                    }

                    for (j = 0; j < (array.Length - index); j++)
                    {
                        resultMatrix[i, j] = array[j + index];
                    }



                }
            }

            return resultMatrix;
        }

        public string MatrixSubstitutionEncrypt(string key)
        {
            return _MatrixSubstitutionEncrypt(key);
        }

        private string turnAllLettersToUpperCase(string s)
        {

            string result = "";
            int i = 0;
            for (i = 0; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]) && char.IsLower(s[i]))
                {
                    result = result + char.ToUpper(s[i]);
                }

                else result = result + s[i];
            }
            return result;
        }

        bool isMissing(char ch, char[] s)
        {
            int i = 0;
            bool result = true;
            for (i = 0; i < s.Length; i++)
            {
                if (ch == s[i]) result = false;
            }
            return result;
        }
        private string _MatrixSubstitutionEncrypt(string key)
        {
            bool isWhiteSpace = false;
            string encr_message = "";
            int i = 0, j = 0;
            char[] array = {'0','1','2','3','4','5','6','7',
                           '8','9','А','Б','В','Г','Д','Е','Ж','З','И','Й','К','Л','М','Н','О','П','Р',
                           'С','Т','У','Ф','Х','Ц','Ч','Ш','Щ','Ъ','Ь','Ю','Я',' ','-',':',
                          /* 'A','B','C','D','E','F','G','H','I',
                           'J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'*/
                           };
            message = turnAllLettersToUpperCase(message);
            key = turnAllLettersToUpperCase(key);
            char[,] matrix = formEncodingMatrix(array, key);
            int repeatKey = ((i + 1) % key.Length);
            if (repeatKey == 0) repeatKey = key.Length;
            for (i = 0; i < message.Length; i++)
            {
                for (j = 0; j < array.Length; j++)
                {
                    if (isMissing(message[i], array))
                    {
                        encr_message = encr_message + message[i];
                        i++;
                        isWhiteSpace = true;
                        if (i == message.Length) break;
                    }
                    if (message[i] == matrix[0, j])
                    {
                        if (!isWhiteSpace) repeatKey = ((i + 1) % key.Length);
                        else repeatKey = (i % key.Length);
                        if (repeatKey == 0)
                        {
                            encr_message = encr_message + matrix[key.Length, j];
                        }
                        else encr_message = encr_message + matrix[repeatKey, j];
                    }

                }

            }

            return encr_message;
        }

        public string MatrixSubstitutionDecrypt(string key)
        {
            return _MatrixSubstitutionDecrypt(key);
        }

        private string _MatrixSubstitutionDecrypt(string key)
        {
            bool isWhiteSpace = false;
            string decr_message = "";
            int i = 0, j = 0;
            char[] array = {'0','1','2','3','4','5','6','7',
                           '8','9','А','Б','В','Г','Д','Е','Ж','З','И','Й','К','Л','М','Н','О','П','Р',
                           'С','Т','У','Ф','Х','Ц','Ч','Ш','Щ','Ъ','Ь','Ю','Я',' ','-',':',
                          /* 'A','B','C','D','E','F','G','H','I',
                           'J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'*/
                           };
            message = turnAllLettersToUpperCase(message);
            key = turnAllLettersToUpperCase(key);
            char[,] matrix = formEncodingMatrix(array, key);
            int repeatKey;
            for (i = 0; i < message.Length; i++)
            {
                for (j = 0; j < array.Length; j++)
                {
                    repeatKey = (i + 1) % key.Length;


                    if (isMissing(message[i], array))
                    {
                        decr_message = decr_message + message[i];
                        i++;
                        isWhiteSpace = true;
                        if (i == message.Length) break;
                    }
                    if (!isWhiteSpace) repeatKey = ((i + 1) % key.Length);
                    else repeatKey = (i % key.Length);
                    if (repeatKey == 0) repeatKey = key.Length;
                    if (matrix[repeatKey, j] == message[i])
                    {
                        decr_message = decr_message + matrix[0, j];
                    }

                }
            }
            return decr_message;
        }
    }
}
