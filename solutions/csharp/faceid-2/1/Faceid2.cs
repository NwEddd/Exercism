public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }

    public override bool Equals(object obj)
    {
        if(obj is not FacialFeatures other)
        {
            return false;
        }

        return EyeColor == other.EyeColor && PhiltrumWidth == other.PhiltrumWidth;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(EyeColor, PhiltrumWidth);
    }


    // TODO: implement equality and GetHashCode() methods
}

public class Identity
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }

    public override bool Equals(object obj)
    {
        if(obj is not Identity other)
        {
            return false;
        }

        return
        Email == other.Email && FacialFeatures.Equals(other.FacialFeatures);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Email, FacialFeatures);
    }


    // TODO: implement equality and GetHashCode() methods
}

public class Authenticator
{
    bool first = true;
    HashSet<Identity> ids = new HashSet<Identity>();
    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB)
    {
        return faceA.Equals(faceB);
    }

    public bool IsAdmin(Identity identity)
    {
        var admin = new Identity ("admin@exerc.ism", new FacialFeatures("green", 0.9m));

        return identity.Equals(admin);
    }

    public bool Register(Identity identity)
    {
        if(!ids.Contains(identity) && first == true)
        {
            ids.Add(identity);
            first = false;
            return true;
        }

        return false;
    }

    public bool IsRegistered(Identity identity)
    {
        return ids.Contains(identity);
    }

    public static bool AreSameObject(Identity identityA, Identity identityB)
    {
        return ReferenceEquals(identityA, identityB);
    }
}
