using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace MyProj;

public class Scripture{
//список из цитат
public static string MakeScriptures(){
    List<string>_Scriptures=new List<string>();
    _Scriptures.Add("For God so loved the world that He gave His only begotten Son, that whosoever believeth in Him should not perish, but have everlasting life.");
    _Scriptures.Add("John 3:16");
    _Scriptures.Add("Trust in the Lord with all thine heart, and lean not unto thine own understanding");
    _Scriptures.Add("in all thy ways acknowledge Him, and He shall direct thy paths.");
    _Scriptures.Add("Proverbs 3:5-6");
    _Scriptures.Add("3 Go your ways; behold, I send you forth as lambs among wolves,");
    _Scriptures.Add("4 carrying neither purse, nor pack, nor shoes; and salute no man by the way.");
    _Scriptures.Add ("5 And into whatsoever house ye enter, first say, ‘Peace be to this house.");
    _Scriptures.Add("Luke 10:3-5");
    _Scriptures.Add("Verily I say unto you, among them that are born of women, there hath not risen a greater than John the Baptist; notwithstanding, he that is least in the Kingdom of Heaven is greater than he.");
    _Scriptures.Add("Matthew 11:11");
    Random random=new Random();
    int randomIndex = random.Next(_Scriptures.Count);
    string _text = _Scriptures[randomIndex]+(" ")+_Scriptures[randomIndex+1];
    return _text;
    //эта переменная приватная а доступ к ней через геттер
}

}