﻿// Decompiled with JetBrains decompiler
// Type: FriedGinger.DQCheat.TemplateEncoding
// Assembly: DQCheat, Version=0.7.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8257ADC3-8608-472B-A2D6-0B748207D880
// Assembly location: C:\Users\yzsco\Downloads\dq9_save_editor_0.7\DQCheat.dll

using System;
using System.Collections.Generic;
using System.Text;

#nullable disable
namespace FriedGinger.DQCheat
{
  public class TemplateEncoding : Encoding
  {
    private static readonly string[] temptags = new string[57]
    {
      ",",
      "1",
      "6",
      "9",
      "66",
      "99",
      "`A",
      "'A",
      "^A",
      ":A",
      "AE",
      ",C",
      "`E",
      "'E",
      "^E",
      ":E",
      "`I",
      "'I",
      "^I",
      ":I",
      "~N",
      "`O",
      "'O",
      "^O",
      "~O",
      ":O",
      "OE",
      "`U",
      "'U",
      "^U",
      ":U",
      "ss",
      "'a",
      "`a",
      "^a",
      ":a",
      "ae",
      ",c",
      "'e",
      "`e",
      "^e",
      ":e",
      "'i",
      "`i",
      "^i",
      ":i",
      "~n",
      "`o",
      "'o",
      "^o",
      "~o",
      ":o",
      "oe",
      "`u",
      "'u",
      "^u",
      ":u"
    };
    private static readonly string tempchars = ",'‘’“”ÀÁÂÄÆÇÈÉÊËÌÍÎÏÑÒÓÔÕÖŒÙÚÛÜßàáâäæçèéêëìíîïñòóôõöœùúûü";
    private static Dictionary<string, char> templateDictionary;

    public TemplateEncoding()
    {
      if (TemplateEncoding.templateDictionary != null)
        return;
      TemplateEncoding.templateDictionary = new Dictionary<string, char>();
      for (int index = 0; index < TemplateEncoding.temptags.Length; ++index)
        TemplateEncoding.templateDictionary.Add(TemplateEncoding.temptags[index], TemplateEncoding.tempchars[index]);
    }

    public override string EncodingName => "DQ9 Template";

    public override string WebName => "dq9-template";

    public override int GetByteCount(char[] chars, int index, int count)
    {
      int byteCount = 0;
      bool flag = false;
      for (int index1 = 0; index1 < count; ++index1)
      {
        char ch = chars[index + index1];
        if (ch == '<')
        {
          if (!flag)
            flag = true;
          else
            continue;
        }
        if (ch == '>')
        {
          if (flag)
            flag = false;
          else
            continue;
        }
        if (!flag)
        {
          int index2 = TemplateEncoding.tempchars.IndexOf(ch);
          if (index2 >= 0)
          {
            byteCount += 2 + TemplateEncoding.temptags[index2].Length;
            continue;
          }
        }
        if (ch >= ' ' && ch <= '~')
          ++byteCount;
      }
      return byteCount;
    }

    public override int GetCharCount(byte[] bytes, int index, int count)
    {
      int charCount = 0;
      bool flag = false;
      StringBuilder stringBuilder = new StringBuilder();
      for (int index1 = 0; index1 < count; ++index1)
      {
        byte num = bytes[index + index1];
        if (num >= (byte) 32 && num <= (byte) 126)
        {
          switch (num)
          {
            case 60:
              flag = true;
              continue;
            case 62:
              if (flag)
              {
                string key = stringBuilder.ToString();
                if (TemplateEncoding.templateDictionary.ContainsKey(key))
                  ++charCount;
                else
                  charCount += 2 + key.Length;
                stringBuilder.Length = 0;
                flag = false;
                continue;
              }
              continue;
            default:
              if (flag)
              {
                stringBuilder.Append((char) num);
                continue;
              }
              ++charCount;
              continue;
          }
        }
      }
      return charCount;
    }

    public override int GetMaxByteCount(int chars) => chars << 2;

    public override int GetMaxCharCount(int bytes) => bytes;

    public override string GetString(byte[] bytes, int index, int count)
    {
      StringBuilder stringBuilder1 = new StringBuilder();
      bool flag = false;
      StringBuilder stringBuilder2 = new StringBuilder();
      for (int index1 = 0; index1 < count; ++index1)
      {
        byte num = bytes[index + index1];
        if (num >= (byte) 32 && num <= (byte) 126)
        {
          switch (num)
          {
            case 60:
              flag = true;
              continue;
            case 62:
              if (flag)
              {
                string key = stringBuilder2.ToString();
                if (TemplateEncoding.templateDictionary.ContainsKey(key))
                  stringBuilder1.Append(TemplateEncoding.templateDictionary[key]);
                else
                  stringBuilder1.Append('<').Append(key).Append('>');
                stringBuilder2.Length = 0;
                flag = false;
                continue;
              }
              continue;
            default:
              if (flag)
              {
                stringBuilder2.Append((char) num);
                continue;
              }
              stringBuilder1.Append((char) num);
              continue;
          }
        }
      }
      return stringBuilder1.ToString();
    }

    public override int GetChars(
      byte[] bytes,
      int byteIndex,
      int byteCount,
      char[] chars,
      int charIndex)
    {
      int num1 = charIndex;
      bool flag = false;
      StringBuilder stringBuilder = new StringBuilder();
      for (int index1 = 0; index1 < byteCount; ++index1)
      {
        byte num2 = bytes[byteIndex + index1];
        if (num2 >= (byte) 32 && num2 <= (byte) 126)
        {
          switch (num2)
          {
            case 60:
              flag = true;
              continue;
            case 62:
              if (flag)
              {
                string key = stringBuilder.ToString();
                if (TemplateEncoding.templateDictionary.ContainsKey(key))
                {
                  chars[num1++] = TemplateEncoding.templateDictionary[key];
                }
                else
                {
                  char[] chArray1 = chars;
                  int index2 = num1;
                  int destinationIndex = index2 + 1;
                  chArray1[index2] = '<';
                  Array.Copy((Array) key.ToCharArray(), 0, (Array) chars, destinationIndex, key.Length);
                  int num3 = destinationIndex + key.Length;
                  char[] chArray2 = chars;
                  int index3 = num3;
                  num1 = index3 + 1;
                  chArray2[index3] = '>';
                }
                stringBuilder.Length = 0;
                flag = false;
                continue;
              }
              continue;
            default:
              if (flag)
              {
                stringBuilder.Append((char) num2);
                continue;
              }
              chars[num1++] = (char) num2;
              continue;
          }
        }
      }
      return num1 - charIndex;
    }

    public override int GetBytes(
      char[] chars,
      int charIndex,
      int charCount,
      byte[] bytes,
      int byteIndex)
    {
      int num1 = byteIndex;
      bool flag = false;
      for (int index1 = 0; index1 < charCount; ++index1)
      {
        char ch = chars[charIndex + index1];
        if (ch == '<')
        {
          if (!flag)
            flag = true;
          else
            continue;
        }
        if (ch == '>')
        {
          if (flag)
            flag = false;
          else
            continue;
        }
        if (!flag)
        {
          int index2 = TemplateEncoding.tempchars.IndexOf(ch);
          if (index2 >= 0)
          {
            byte[] numArray1 = bytes;
            int index3 = num1;
            int num2 = index3 + 1;
            numArray1[index3] = (byte) 60;
            foreach (byte num3 in TemplateEncoding.temptags[index2])
              bytes[num2++] = num3;
            byte[] numArray2 = bytes;
            int index4 = num2;
            num1 = index4 + 1;
            numArray2[index4] = (byte) 62;
            continue;
          }
        }
        if (ch >= ' ' && ch <= '~')
          bytes[num1++] = (byte) ch;
      }
      return num1 - byteIndex;
    }
  }
}