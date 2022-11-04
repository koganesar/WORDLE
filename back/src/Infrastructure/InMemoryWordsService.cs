﻿using Application;
using Domain.Entities;

namespace Infrastructure;

public class InMemoryWordsService : IWordsService
{
    public Task<IEnumerable<Word>> GetWordsAsync() =>
        Task.FromResult(new[]
            {
                "ALBUM", "HINGE", "MONEY", "SCRAP", "GAMER", "GLASS", "SCOUR", "BEING", "DELVE", "YIELD", "METAL",
                "TIPSY", "SLUNG", "FARCE", "GECKO", "SHINE", "CANNY", "MIDST", "BADGE", "HOMER", "TRAIN", "STORY",
                "HAIRY", "FORGO", "LARVA", "TRASH", "ZESTY", "SHOWN", "HEIST", "ASKEW", "INERT", "OLIVE", "PLANT",
                "OXIDE", "CARGO", "FOYER", "FLAIR", "AMPLE", "CHEEK", "SHAME", "MINCE", "CHUNK", "ROYAL", "SQUAD",
                "BLACK", "STAIR", "SCARE", "FORAY", "COMMA", "NATAL", "SHAWL", "FEWER", "TROPE", "SNOUT", "LOWLY",
                "STOVE", "SHALL", "FOUND", "NYMPH", "EPOXY", "DEPOT", "CHEST", "PURGE", "SLOSH", "THEIR", "RENEW",
                "ALLOW", "SAUTE", "MOVIE", "CATER", "TEASE", "SMELT", "FOCUS", "TODAY", "WATCH", "LAPSE", "MONTH",
                "SWEET", "HOARD", "CLOTH", "BRINE", "AHEAD", "MOURN", "NASTY", "RUPEE", "CHOKE", "CHANT", "SPILL",
                "VIVID", "BLOKE", "TROVE", "THORN", "OTHER", "TACIT", "SWILL", "DODGE", "SHAKE", "CAULK", "AROMA",
                "CYNIC", "ROBIN", "ULTRA", "ULCER", "PAUSE", "HUMOR", "FRAME", "ELDER", "SKILL", "ALOFT", "PLEAT",
                "SHARD", "MOIST", "THOSE", "LIGHT", "WRUNG", "COULD", "PERKY", "MOUNT", "WHACK", "SUGAR", "KNOLL",
                "CRIMP", "WINCE", "PRICK", "ROBOT", "POINT", "PROXY", "SHIRE", "SOLAR", "PANIC", "TANGY", "ABBEY",
                "FAVOR", "DRINK", "QUERY", "GORGE", "CRANK", "SLUMP", "BANAL", "TIGER", "SIEGE", "TRUSS", "BOOST",
                "REBUS", "UNIFY", "TROLL", "TAPIR", "ASIDE", "FERRY", "ACUTE", "PICKY", "WEARY", "GRIPE", "CRAZE",
                "PLUCK", "BRAKE", "BATON", "CHAMP", "PEACH", "USING", "TRACE", "VITAL", "SONIC", "MASSE", "CONIC",
                "VIRAL", "RHINO", "BREAK", "TRIAD", "EPOCH", "USHER", "EXULT", "GRIME", "CHEAT", "SOLVE", "BRING",
                "PROVE", "STORE", "TILDE", "CLOCK", "WROTE", "RETCH", "PERCH", "ROUGE", "RADIO", "SURER", "FINER",
                "VODKA", "HERON", "CHILL", "GAUDY", "PITHY", "SMART", "BADLY", "ROGUE", "GROUP", "FIXER", "GROIN",
                "DUCHY", "COAST", "BLURT", "PULPY", "ALTAR", "GREAT", "BRIAR", "CLICK", "GOUGE", "WORLD", "ERODE",
                "BOOZY", "DOZEN", "FLING", "GROWL", "ABYSS", "STEED", "ENEMA", "JAUNT", "COMET", "TWEED", "PILOT",
                "DUTCH", "BELCH", "OUGHT", "DOWRY", "THUMB", "HYPER", "HATCH", "ALONE", "MOTOR", "ABACK", "GUILD",
                "KEBAB", "SPEND", "FJORD", "ESSAY", "SPRAY", "SPICY", "AGATE", "SALAD", "BASIC", "MOULT", "CORNY",
                "FORGE", "CIVIC", "ISLET", "LABOR", "GAMMA", "LYING", "AUDIT", "ROUND", "LOOPY", "LUSTY", "GOLEM",
                "GONER", "GREET", "START", "LAPEL", "BIOME", "PARRY", "SHRUB", "FRONT", "WOOER", "TOTEM", "FLICK",
                "DELTA", "BLEED", "ARGUE", "SWIRL", "ERROR", "AGREE", "OFFAL", "FLUME", "CRASS", "PANEL", "STOUT",
                "BRIBE", "DRAIN", "YEARN", "PRINT", "SEEDY", "IVORY", "BELLY", "STAND", "FIRST", "FORTH", "BOOBY",
                "FLESH", "UNMET", "LINEN", "MAXIM", "POUND", "MIMIC", "SPIKE", "CLUCK", "CRATE", "DIGIT", "REPAY",
                "SOWER", "CRAZY", "ADOBE", "OUTDO", "TRAWL", "WHELP", "UNFED", "PAPER", "STAFF", "CROAK", "HELIX",
                "FLOSS", "PRIDE", "BATTY", "REACT", "MARRY", "ABASE", "COLON", "STOOL", "CRUST", "FRESH", "DEATH",
                "MAJOR", "FEIGN", "ABATE", "BENCH", "QUIET", "GRADE", "STINK", "KARMA", "MODEL", "DWARF", "HEATH",
                "SERVE", "NAVAL", "EVADE", "FOCAL", "BLUSH", "AWAKE", "HUMPH", "SISSY", "REBUT", "CIGAR"
            }
            .Select(word => new Word {Self = word}));
}
