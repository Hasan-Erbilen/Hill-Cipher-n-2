using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class HillCipher
    {
        int[,] enc_mat;
        int[,] dec_mat;
        String codec_key = "DBEF";
        const String alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890 ";
        int alphabet_count = alphabet.Length;
        // Following function generates the  
        // key matrix for the key string  

        public HillCipher()
        {
            make_key_mat();
        }

        int do_euclid(int[] a, int[] b)
        {
            if(b[2] == 1) 
            {
                return validate_number(b[1]);
            }
            int q = a[2] / b[2];
            int t;
            for (int i = 0; i < 3; i++)
            {
                t = a[i] - q * b[i];
                a[i] = b[i];
                b[i] = t;
            }

            return do_euclid(a, b);
        }


        void make_key_mat()
        {
            this.enc_mat = new int[2, 2];
            this.dec_mat = new int[2, 2];

            int k = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    enc_mat[i, j] = alphabet.IndexOf(codec_key[k]);
                    k++;
                }
            }

            int det = enc_mat[0, 0] * enc_mat[1, 1] - enc_mat[0, 1] * enc_mat[1, 0];

            int[] a = { 1, 0, alphabet_count };
            int[] b = { 0, 1, det };

            int inv_det = do_euclid(a, b);

            this.dec_mat[0, 0] = validate_number(+this.enc_mat[1, 1] * inv_det);
            this.dec_mat[0, 1] = validate_number((alphabet_count -this.enc_mat[0, 1]) * inv_det);
            this.dec_mat[1, 0] = validate_number((alphabet_count-this.enc_mat[1, 0]) * inv_det);
            this.dec_mat[1, 1] = validate_number(+this.enc_mat[0, 0] * inv_det);

        }

        int validate_number(int k)
        {
            return ((k % alphabet_count) + alphabet_count) % alphabet_count;
        }

        // Following function encrypts the message  
        void encrypt(int[,] cipherMatrix, int[,] messageVector)
        {
            int x, i, j;
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 1; j++)
                {
                    cipherMatrix[i, j] = 0;

                    for (x = 0; x < 2; x++)
                    {
                        cipherMatrix[i, j] += enc_mat[i, x] *
                                              messageVector[x, j];
                    }

                    cipherMatrix[i, j]  = validate_number(cipherMatrix[i, j]);
                }
            }
        }

        // Following function encrypts the message  
        void decrypt(int[,] cipherMatrix, int[,] messageVector)
        {
            int x, i, j;
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 1; j++)
                {
                    cipherMatrix[i, j] = 0;

                    for (x = 0; x < 2; x++)
                    {
                        cipherMatrix[i, j] += dec_mat[i, x] *
                                              messageVector[x, j];
                    }

                    cipherMatrix[i, j] = validate_number(cipherMatrix[i, j]);
                }
            }
        }

        // Function to implement Hill Cipher  
        public String encryptText(String message)
        {

            if(message.Length % 2 != 0) 
            {
                message += ' ';
            }

            message = message.ToUpper();
            // Get key matrix from the key string  
            String CipherText = "";
            for (int idx = 0; idx < message.Length; idx += 2)
            {
                int[,] messageVector = new int[2, 1];

                // Generate vector for the message  
                for (int i = 0; i < 2 && idx + i < message.Length; i++) 
                {
                    int char_no = alphabet.IndexOf(message[idx + i]);
                    if(char_no == -1)
                    {
                        return "Invalid Char Found";
                    }
                    messageVector[i, 0] = char_no;
                }

                int[,] cipherMatrix = new int[2, 1];

                // Following function generates  
                // the encrypted vector  
                encrypt(cipherMatrix, messageVector);

                // Generate the encrypted text from  
                // the encrypted vector  
                for (int i = 0; i < 2 && idx + i < message.Length; i++)
                    CipherText += alphabet[cipherMatrix[i, 0] % alphabet_count];
            }
            return CipherText;
        }

        // Function to implement Hill Cipher  
        public String decryptText(String message)
        {

            // Get key matrix from the key string  
            String CipherText = "";
            for (int idx = 0; idx < message.Length; idx += 2)
            {
                int[,] messageVector = new int[2, 1];

                // Generate vector for the message  
                for (int i = 0; i < 2 && idx + i < message.Length; i++)
                {
                    int char_no = alphabet.IndexOf(message[idx + i]);
                    if (char_no == -1)
                    {
                        return "Invalid Char Found";
                    }
                    messageVector[i, 0] = char_no;
                }

                int[,] cipherMatrix = new int[2, 1];

                // Following function generates  
                // the encrypted vector  
                decrypt(cipherMatrix, messageVector);

                // Generate the encrypted text from  
                // the encrypted vector  
                for (int i = 0; i < 2 && idx + i < message.Length; i++)
                    CipherText += alphabet[cipherMatrix[i, 0]];
            }
            return CipherText;
        }

        public void setKey(String key)
        {
            this.codec_key = key;
            make_key_mat();
        }

    }
}
