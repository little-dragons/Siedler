namespace Lini.Rendering.GLBindings;

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal enum EnableCap : uint
{
	DebugOutputSynchronous = 33346,
	DebugOutput = 37600,
	LineSmooth = 2848,
	PolygonSmooth = 2881,
	CullFace = 2884,
	DepthTest = 2929,
	StencilTest = 2960,
	Dither = 3024,
	Blend = 3042,
	ScissorTest = 3089,
	Texture1d = 3552,
	Texture2d = 3553,
	ColorLogicOp = 3058,
	PolygonOffsetPoint = 10753,
	PolygonOffsetLine = 10754,
	PolygonOffsetFill = 32823,
	Multisample = 32925,
	SampleAlphaToCoverage = 32926,
	SampleAlphaToOne = 32927,
	SampleCoverage = 32928,
	TextureCubeMap = 34067,
	ClipDistance0 = 12288,
	ClipDistance1 = 12289,
	ClipDistance2 = 12290,
	ClipDistance3 = 12291,
	ClipDistance4 = 12292,
	ClipDistance5 = 12293,
	ClipDistance6 = 12294,
	ClipDistance7 = 12295,
	RasterizerDiscard = 35977,
	FramebufferSrgb = 36281,
	TextureRectangle = 34037,
	PrimitiveRestart = 36765,
	ProgramPointSize = 34370,
	DepthClamp = 34383,
	TextureCubeMapSeamless = 34895,
	SampleMask = 36433,
	SampleShading = 35894,
	PrimitiveRestartFixedIndex = 36201,
	VertexArray = 32884,
}

internal enum GetPointervPName : uint
{
	Function = 33348,
	UserParam = 33349,
}

internal enum DebugSource : uint
{
	Api = 33350,
	WindowSystem = 33351,
	ShaderCompiler = 33352,
	ThirdParty = 33353,
	Application = 33354,
	Other = 33355,
	DontCare = 4352,
}

internal enum DebugType : uint
{
	Error = 33356,
	DeprecatedBehavior = 33357,
	UndefinedBehavior = 33358,
	Portability = 33359,
	Performance = 33360,
	Other = 33361,
	Marker = 33384,
	PushGroup = 33385,
	PopGroup = 33386,
	DontCare = 4352,
}

internal enum DebugSeverity : uint
{
	Notification = 33387,
	High = 37190,
	Medium = 37191,
	Low = 37192,
	DontCare = 4352,
}

internal enum GetPName : uint
{
	MaxDebugGroupStackDepth = 33388,
	DebugGroupStackDepth = 33389,
	MaxLabelLength = 33512,
	PointSize = 2833,
	PointSizeRange = 2834,
	PointSizeGranularity = 2835,
	LineSmooth = 2848,
	LineWidth = 2849,
	LineWidthRange = 2850,
	LineWidthGranularity = 2851,
	PolygonMode = 2880,
	PolygonSmooth = 2881,
	CullFace = 2884,
	CullFaceMode = 2885,
	FrontFace = 2886,
	DepthRange = 2928,
	DepthTest = 2929,
	DepthWritemask = 2930,
	DepthClearValue = 2931,
	DepthFunc = 2932,
	StencilTest = 2960,
	StencilClearValue = 2961,
	StencilFunc = 2962,
	StencilValueMask = 2963,
	StencilFail = 2964,
	StencilPassDepthFail = 2965,
	StencilPassDepthPass = 2966,
	StencilRef = 2967,
	StencilWritemask = 2968,
	Viewport = 2978,
	Dither = 3024,
	BlendDst = 3040,
	BlendSrc = 3041,
	Blend = 3042,
	LogicOpMode = 3056,
	DrawBuffer = 3073,
	ReadBuffer = 3074,
	ScissorBox = 3088,
	ScissorTest = 3089,
	ColorClearValue = 3106,
	ColorWritemask = 3107,
	Doublebuffer = 3122,
	Stereo = 3123,
	LineSmoothHint = 3154,
	PolygonSmoothHint = 3155,
	UnpackSwapBytes = 3312,
	UnpackLsbFirst = 3313,
	UnpackRowLength = 3314,
	UnpackSkipRows = 3315,
	UnpackSkipPixels = 3316,
	UnpackAlignment = 3317,
	PackSwapBytes = 3328,
	PackLsbFirst = 3329,
	PackRowLength = 3330,
	PackSkipRows = 3331,
	PackSkipPixels = 3332,
	PackAlignment = 3333,
	MaxTextureSize = 3379,
	MaxViewportDims = 3386,
	SubpixelBits = 3408,
	Texture1d = 3552,
	Texture2d = 3553,
	ColorLogicOp = 3058,
	PolygonOffsetUnits = 10752,
	PolygonOffsetPoint = 10753,
	PolygonOffsetLine = 10754,
	PolygonOffsetFill = 32823,
	PolygonOffsetFactor = 32824,
	TextureBinding1d = 32872,
	TextureBinding2d = 32873,
	TextureBinding3d = 32874,
	PackSkipImages = 32875,
	PackImageHeight = 32876,
	UnpackSkipImages = 32877,
	UnpackImageHeight = 32878,
	Max3dTextureSize = 32883,
	MaxElementsVertices = 33000,
	MaxElementsIndices = 33001,
	SmoothPointSizeRange = 2834,
	SmoothPointSizeGranularity = 2835,
	SmoothLineWidthRange = 2850,
	SmoothLineWidthGranularity = 2851,
	AliasedLineWidthRange = 33902,
	ActiveTexture = 34016,
	SampleBuffers = 32936,
	Samples = 32937,
	SampleCoverageValue = 32938,
	SampleCoverageInvert = 32939,
	TextureBindingCubeMap = 34068,
	MaxCubeMapTextureSize = 34076,
	TextureCompressionHint = 34031,
	NumCompressedTextureFormats = 34466,
	CompressedTextureFormats = 34467,
	BlendDstRgb = 32968,
	BlendSrcRgb = 32969,
	BlendDstAlpha = 32970,
	BlendSrcAlpha = 32971,
	PointFadeThresholdSize = 33064,
	MaxTextureLodBias = 34045,
	BlendColor = 32773,
	BlendEquation = 32777,
	ArrayBufferBinding = 34964,
	ElementArrayBufferBinding = 34965,
	BlendEquationRgb = 32777,
	StencilBackFunc = 34816,
	StencilBackFail = 34817,
	StencilBackPassDepthFail = 34818,
	StencilBackPassDepthPass = 34819,
	MaxDrawBuffers = 34852,
	BlendEquationAlpha = 34877,
	MaxVertexAttribs = 34921,
	MaxTextureImageUnits = 34930,
	MaxFragmentUniformComponents = 35657,
	MaxVertexUniformComponents = 35658,
	MaxVaryingFloats = 35659,
	MaxVertexTextureImageUnits = 35660,
	MaxCombinedTextureImageUnits = 35661,
	FragmentShaderDerivativeHint = 35723,
	CurrentProgram = 35725,
	StencilBackRef = 36003,
	StencilBackValueMask = 36004,
	StencilBackWritemask = 36005,
	PixelPackBufferBinding = 35053,
	PixelUnpackBufferBinding = 35055,
	MaxClipDistances = 3378,
	MajorVersion = 33307,
	MinorVersion = 33308,
	NumExtensions = 33309,
	ContextFlags = 33310,
	MaxArrayTextureLayers = 35071,
	MinProgramTexelOffset = 35076,
	MaxProgramTexelOffset = 35077,
	MaxVaryingComponents = 35659,
	TextureBinding1dArray = 35868,
	TextureBinding2dArray = 35869,
	TransformFeedbackBufferStart = 35972,
	TransformFeedbackBufferSize = 35973,
	TransformFeedbackBufferBinding = 35983,
	MaxRenderbufferSize = 34024,
	DrawFramebufferBinding = 36006,
	RenderbufferBinding = 36007,
	ReadFramebufferBinding = 36010,
	MaxColorAttachments = 36063,
	VertexArrayBinding = 34229,
	MaxTextureBufferSize = 35883,
	TextureBindingBuffer = 35884,
	TextureBindingRectangle = 34038,
	MaxRectangleTextureSize = 34040,
	PrimitiveRestartIndex = 36766,
	UniformBufferBinding = 35368,
	UniformBufferStart = 35369,
	UniformBufferSize = 35370,
	MaxVertexUniformBlocks = 35371,
	MaxGeometryUniformBlocks = 35372,
	MaxFragmentUniformBlocks = 35373,
	MaxCombinedUniformBlocks = 35374,
	MaxUniformBufferBindings = 35375,
	MaxUniformBlockSize = 35376,
	MaxCombinedVertexUniformComponents = 35377,
	MaxCombinedGeometryUniformComponents = 35378,
	MaxCombinedFragmentUniformComponents = 35379,
	UniformBufferOffsetAlignment = 35380,
	ProgramPointSize = 34370,
	MaxGeometryTextureImageUnits = 35881,
	MaxGeometryUniformComponents = 36319,
	MaxVertexOutputComponents = 37154,
	MaxGeometryInputComponents = 37155,
	MaxGeometryOutputComponents = 37156,
	MaxFragmentInputComponents = 37157,
	ContextProfileMask = 37158,
	ProvokingVertex = 36431,
	MaxServerWaitTimeout = 37137,
	MaxSampleMaskWords = 36441,
	TextureBinding2dMultisample = 37124,
	TextureBinding2dMultisampleArray = 37125,
	MaxColorTextureSamples = 37134,
	MaxDepthTextureSamples = 37135,
	MaxIntegerSamples = 37136,
	MaxDualSourceDrawBuffers = 35068,
	SamplerBinding = 35097,
	Timestamp = 36392,
	MaxTessControlUniformBlocks = 36489,
	MaxTessEvaluationUniformBlocks = 36490,
	ImplementationColorReadType = 35738,
	ImplementationColorReadFormat = 35739,
	ShaderCompiler = 36346,
	ShaderBinaryFormats = 36344,
	NumShaderBinaryFormats = 36345,
	MaxVertexUniformVectors = 36347,
	MaxVaryingVectors = 36348,
	MaxFragmentUniformVectors = 36349,
	NumProgramBinaryFormats = 34814,
	ProgramBinaryFormats = 34815,
	ProgramPipelineBinding = 33370,
	MaxViewports = 33371,
	ViewportSubpixelBits = 33372,
	ViewportBoundsRange = 33373,
	LayerProvokingVertex = 33374,
	ViewportIndexProvokingVertex = 33375,
	MinMapBufferAlignment = 37052,
	MaxVertexAtomicCounters = 37586,
	MaxTessControlAtomicCounters = 37587,
	MaxTessEvaluationAtomicCounters = 37588,
	MaxGeometryAtomicCounters = 37589,
	MaxFragmentAtomicCounters = 37590,
	MaxCombinedAtomicCounters = 37591,
	MaxElementIndex = 36203,
	MaxComputeUniformBlocks = 37307,
	MaxComputeTextureImageUnits = 37308,
	MaxComputeUniformComponents = 33379,
	MaxComputeAtomicCounterBuffers = 33380,
	MaxComputeAtomicCounters = 33381,
	MaxCombinedComputeUniformComponents = 33382,
	MaxComputeWorkGroupInvocations = 37099,
	MaxComputeWorkGroupCount = 37310,
	MaxComputeWorkGroupSize = 37311,
	DispatchIndirectBufferBinding = 37103,
	VertexArray = 32884,
	MaxUniformLocations = 33390,
	MaxFramebufferWidth = 37653,
	MaxFramebufferHeight = 37654,
	MaxFramebufferLayers = 37655,
	MaxFramebufferSamples = 37656,
	ShaderStorageBufferBinding = 37075,
	ShaderStorageBufferStart = 37076,
	ShaderStorageBufferSize = 37077,
	MaxVertexShaderStorageBlocks = 37078,
	MaxGeometryShaderStorageBlocks = 37079,
	MaxTessControlShaderStorageBlocks = 37080,
	MaxTessEvaluationShaderStorageBlocks = 37081,
	MaxFragmentShaderStorageBlocks = 37082,
	MaxComputeShaderStorageBlocks = 37083,
	MaxCombinedShaderStorageBlocks = 37084,
	MaxShaderStorageBufferBindings = 37085,
	ShaderStorageBufferOffsetAlignment = 37087,
	TextureBufferOffsetAlignment = 37279,
	VertexBindingDivisor = 33494,
	VertexBindingOffset = 33495,
	VertexBindingStride = 33496,
	MaxVertexAttribRelativeOffset = 33497,
	MaxVertexAttribBindings = 33498,
}

internal enum ObjectIdentifier : uint
{
	Buffer = 33504,
	Shader = 33505,
	Program = 33506,
	Query = 33507,
	ProgramPipeline = 33508,
	Sampler = 33510,
	Texture = 5890,
	Framebuffer = 36160,
	Renderbuffer = 36161,
	TransformFeedback = 36386,
	VertexArray = 32884,
}

internal enum ContextFlagMask : uint
{
	Debug = 2,
	DebugKHR = 2,
	ForwardCompatible = 1,
	RobustAccess = 4,
}

internal enum ClearBufferMask : uint
{
	Depth = 256,
	Stencil = 1024,
	Color = 16384,
}

internal enum AttribMask : uint
{
	Depth = 256,
	Stencil = 1024,
	Color = 16384,
}

internal enum Boolean : uint
{
	False = 0,
	True = 1,
}

internal enum VertexShaderWriteMaskEXT : uint
{
	False = 0,
	True = 1,
}

internal enum ClampColorModeARB : uint
{
	False = 0,
	True = 1,
	FixedOnly = 35101,
}

internal enum PrimitiveType : uint
{
	Points = 0,
	Lines = 1,
	LineLoop = 2,
	LineStrip = 3,
	Triangles = 4,
	TriangleStrip = 5,
	TriangleFan = 6,
	LinesAdjacency = 10,
	LineStripAdjacency = 11,
	TrianglesAdjacency = 12,
	TriangleStripAdjacency = 13,
	Patches = 14,
	Quads = 7,
}

internal enum StencilFunction : uint
{
	Never = 512,
	Less = 513,
	Equal = 514,
	Lequal = 515,
	Greater = 516,
	Notequal = 517,
	Gequal = 518,
	Always = 519,
}

internal enum IndexFunctionEXT : uint
{
	Never = 512,
	Less = 513,
	Equal = 514,
	Lequal = 515,
	Greater = 516,
	Notequal = 517,
	Gequal = 518,
	Always = 519,
}

internal enum AlphaFunction : uint
{
	Never = 512,
	Less = 513,
	Equal = 514,
	Lequal = 515,
	Greater = 516,
	Notequal = 517,
	Gequal = 518,
	Always = 519,
}

internal enum DepthFunction : uint
{
	Never = 512,
	Less = 513,
	Equal = 514,
	Lequal = 515,
	Greater = 516,
	Notequal = 517,
	Gequal = 518,
	Always = 519,
}

internal enum TextureSwizzle : uint
{
	Zero = 0,
	One = 1,
	Red = 6403,
	Green = 6404,
	Blue = 6405,
	Alpha = 6406,
}

internal enum StencilOp : uint
{
	Zero = 0,
	Invert = 5386,
	Keep = 7680,
	Replace = 7681,
	Incr = 7682,
	Decr = 7683,
	IncrWrap = 34055,
	DecrWrap = 34056,
}

internal enum BlendingFactor : uint
{
	Zero = 0,
	One = 1,
	SrcColor = 768,
	OneMinusSrcColor = 769,
	SrcAlpha = 770,
	OneMinusSrcAlpha = 771,
	DstAlpha = 772,
	OneMinusDstAlpha = 773,
	DstColor = 774,
	OneMinusDstColor = 775,
	SrcAlphaSaturate = 776,
	ConstantColor = 32769,
	OneMinusConstantColor = 32770,
	ConstantAlpha = 32771,
	OneMinusConstantAlpha = 32772,
	Src1Alpha = 34185,
	Src1Color = 35065,
	OneMinusSrc1Color = 35066,
	OneMinusSrc1Alpha = 35067,
}

internal enum FragmentShaderGenericSourceATI : uint
{
	Zero = 0,
	One = 1,
}

internal enum FragmentShaderValueRepATI : uint
{
	None = 0,
	Red = 6403,
	Green = 6404,
	Blue = 6405,
	Alpha = 6406,
}

internal enum FragmentShaderDestModMaskATI : uint
{
	None = 0,
}

internal enum FragmentShaderDestMaskATI : uint
{
	None = 0,
}

internal enum SyncBehaviorFlags : uint
{
	None = 0,
}

internal enum TextureCompareMode : uint
{
	None = 0,
	CompareRefToTexture = 34894,
}

internal enum PathColorFormat : uint
{
	None = 0,
	Alpha = 6406,
	Rgb = 6407,
	Rgba = 6408,
}

internal enum CombinerBiasNV : uint
{
	None = 0,
}

internal enum CombinerScaleNV : uint
{
	None = 0,
}

internal enum DrawBufferMode : uint
{
	None = 0,
	FrontLeft = 1024,
	FrontRight = 1025,
	BackLeft = 1026,
	BackRight = 1027,
	Front = 1028,
	Back = 1029,
	Left = 1030,
	Right = 1031,
	FrontAndBack = 1032,
	ColorAttachment0 = 36064,
	ColorAttachment1 = 36065,
	ColorAttachment2 = 36066,
	ColorAttachment3 = 36067,
	ColorAttachment4 = 36068,
	ColorAttachment5 = 36069,
	ColorAttachment6 = 36070,
	ColorAttachment7 = 36071,
	ColorAttachment8 = 36072,
	ColorAttachment9 = 36073,
	ColorAttachment10 = 36074,
	ColorAttachment11 = 36075,
	ColorAttachment12 = 36076,
	ColorAttachment13 = 36077,
	ColorAttachment14 = 36078,
	ColorAttachment15 = 36079,
	ColorAttachment16 = 36080,
	ColorAttachment17 = 36081,
	ColorAttachment18 = 36082,
	ColorAttachment19 = 36083,
	ColorAttachment20 = 36084,
	ColorAttachment21 = 36085,
	ColorAttachment22 = 36086,
	ColorAttachment23 = 36087,
	ColorAttachment24 = 36088,
	ColorAttachment25 = 36089,
	ColorAttachment26 = 36090,
	ColorAttachment27 = 36091,
	ColorAttachment28 = 36092,
	ColorAttachment29 = 36093,
	ColorAttachment30 = 36094,
	ColorAttachment31 = 36095,
}

internal enum PixelTexGenModeSGIX : uint
{
	None = 0,
	Alpha = 6406,
	Rgb = 6407,
	Rgba = 6408,
}

internal enum ReadBufferMode : uint
{
	None = 0,
	FrontLeft = 1024,
	FrontRight = 1025,
	BackLeft = 1026,
	BackRight = 1027,
	Front = 1028,
	Back = 1029,
	Left = 1030,
	Right = 1031,
	ColorAttachment0 = 36064,
	ColorAttachment1 = 36065,
	ColorAttachment2 = 36066,
	ColorAttachment3 = 36067,
	ColorAttachment4 = 36068,
	ColorAttachment5 = 36069,
	ColorAttachment6 = 36070,
	ColorAttachment7 = 36071,
	ColorAttachment8 = 36072,
	ColorAttachment9 = 36073,
	ColorAttachment10 = 36074,
	ColorAttachment11 = 36075,
	ColorAttachment12 = 36076,
	ColorAttachment13 = 36077,
	ColorAttachment14 = 36078,
	ColorAttachment15 = 36079,
}

internal enum ColorBuffer : uint
{
	None = 0,
	FrontLeft = 1024,
	FrontRight = 1025,
	BackLeft = 1026,
	BackRight = 1027,
	Front = 1028,
	Back = 1029,
	Left = 1030,
	Right = 1031,
	FrontAndBack = 1032,
	ColorAttachment0 = 36064,
	ColorAttachment1 = 36065,
	ColorAttachment2 = 36066,
	ColorAttachment3 = 36067,
	ColorAttachment4 = 36068,
	ColorAttachment5 = 36069,
	ColorAttachment6 = 36070,
	ColorAttachment7 = 36071,
	ColorAttachment8 = 36072,
	ColorAttachment9 = 36073,
	ColorAttachment10 = 36074,
	ColorAttachment11 = 36075,
	ColorAttachment12 = 36076,
	ColorAttachment13 = 36077,
	ColorAttachment14 = 36078,
	ColorAttachment15 = 36079,
	ColorAttachment16 = 36080,
	ColorAttachment17 = 36081,
	ColorAttachment18 = 36082,
	ColorAttachment19 = 36083,
	ColorAttachment20 = 36084,
	ColorAttachment21 = 36085,
	ColorAttachment22 = 36086,
	ColorAttachment23 = 36087,
	ColorAttachment24 = 36088,
	ColorAttachment25 = 36089,
	ColorAttachment26 = 36090,
	ColorAttachment27 = 36091,
	ColorAttachment28 = 36092,
	ColorAttachment29 = 36093,
	ColorAttachment30 = 36094,
	ColorAttachment31 = 36095,
}

internal enum PathGenMode : uint
{
	None = 0,
}

internal enum PathTransformType : uint
{
	None = 0,
}

internal enum PathFontStyle : uint
{
	None = 0,
}

internal enum TriangleFace : uint
{
	Front = 1028,
	Back = 1029,
	FrontAndBack = 1032,
}

internal enum GraphicsResetStatus : uint
{
	NoError = 0,
	GuiltyContextReset = 33363,
	InnocentContextReset = 33364,
	UnknownContextReset = 33365,
}

internal enum ErrorCode : uint
{
	NoError = 0,
	InvalidEnum = 1280,
	InvalidValue = 1281,
	InvalidOperation = 1282,
	OutOfMemory = 1285,
	InvalidFramebufferOperation = 1286,
	StackUnderflow = 1284,
	StackOverflow = 1283,
}

internal enum FrontFaceDirection : uint
{
	Cw = 2304,
	Ccw = 2305,
}

internal enum TextureEnvMode : uint
{
	Blend = 3042,
	Replace = 7681,
}

internal enum GetFramebufferParameter : uint
{
	Doublebuffer = 3122,
	Stereo = 3123,
	SampleBuffers = 32936,
	Samples = 32937,
	ImplementationColorReadType = 35738,
	ImplementationColorReadFormat = 35739,
	FramebufferDefaultWidth = 37648,
	FramebufferDefaultHeight = 37649,
	FramebufferDefaultLayers = 37650,
	FramebufferDefaultSamples = 37651,
	FramebufferDefaultFixedSampleLocations = 37652,
}

internal enum HintTarget : uint
{
	LineSmooth = 3154,
	PolygonSmooth = 3155,
	TextureCompression = 34031,
	FragmentShaderDerivative = 35723,
	ProgramBinaryRetrievable = 33367,
}

internal enum PixelStoreParameter : uint
{
	UnpackSwapBytes = 3312,
	UnpackLsbFirst = 3313,
	UnpackRowLength = 3314,
	UnpackSkipRows = 3315,
	UnpackSkipPixels = 3316,
	UnpackAlignment = 3317,
	PackSwapBytes = 3328,
	PackLsbFirst = 3329,
	PackRowLength = 3330,
	PackSkipRows = 3331,
	PackSkipPixels = 3332,
	PackAlignment = 3333,
	PackSkipImages = 32875,
	PackImageHeight = 32876,
	UnpackSkipImages = 32877,
	UnpackImageHeight = 32878,
}

internal enum CopyImageSubDataTarget : uint
{
	Texture1d = 3552,
	Texture2d = 3553,
	Texture3d = 32879,
	TextureCubeMap = 34067,
	Texture1dArray = 35864,
	Texture2dArray = 35866,
	Renderbuffer = 36161,
	TextureRectangle = 34037,
	Texture2dMultisample = 37120,
	Texture2dMultisampleArray = 37122,
	TextureCubeMapArray = 36873,
}

internal enum TextureTarget : uint
{
	Texture1d = 3552,
	Texture2d = 3553,
	ProxyTexture1d = 32867,
	ProxyTexture2d = 32868,
	Texture3d = 32879,
	ProxyTexture3d = 32880,
	TextureCubeMap = 34067,
	TextureCubeMapPositiveX = 34069,
	TextureCubeMapNegativeX = 34070,
	TextureCubeMapPositiveY = 34071,
	TextureCubeMapNegativeY = 34072,
	TextureCubeMapPositiveZ = 34073,
	TextureCubeMapNegativeZ = 34074,
	ProxyTextureCubeMap = 34075,
	Texture1dArray = 35864,
	ProxyTexture1dArray = 35865,
	Texture2dArray = 35866,
	ProxyTexture2dArray = 35867,
	Renderbuffer = 36161,
	TextureBuffer = 35882,
	TextureRectangle = 34037,
	ProxyTextureRectangle = 34039,
	Texture2dMultisample = 37120,
	ProxyTexture2dMultisample = 37121,
	Texture2dMultisampleArray = 37122,
	ProxyTexture2dMultisampleArray = 37123,
	TextureCubeMapArray = 36873,
	ProxyTextureCubeMapArray = 36875,
}

internal enum TextureParameterName : uint
{
	TextureWidth = 4096,
	TextureHeight = 4097,
	TextureBorderColor = 4100,
	TextureMagFilter = 10240,
	TextureMinFilter = 10241,
	TextureWrapS = 10242,
	TextureWrapT = 10243,
	TextureInternalFormat = 4099,
	TextureRedSize = 32860,
	TextureGreenSize = 32861,
	TextureBlueSize = 32862,
	TextureAlphaSize = 32863,
	TextureWrapR = 32882,
	TextureMinLod = 33082,
	TextureMaxLod = 33083,
	TextureBaseLevel = 33084,
	TextureMaxLevel = 33085,
	TextureLodBias = 34049,
	TextureCompareMode = 34892,
	TextureCompareFunc = 34893,
	TextureSwizzleR = 36418,
	TextureSwizzleG = 36419,
	TextureSwizzleB = 36420,
	TextureSwizzleA = 36421,
	TextureSwizzleRgba = 36422,
	DepthStencilTextureMode = 37098,
}

internal enum GetTextureParameter : uint
{
	Width = 4096,
	Height = 4097,
	BorderColor = 4100,
	MagFilter = 10240,
	MinFilter = 10241,
	WrapS = 10242,
	WrapT = 10243,
	InternalFormat = 4099,
	RedSize = 32860,
	GreenSize = 32861,
	BlueSize = 32862,
	AlphaSize = 32863,
}

internal enum SamplerParameterF : uint
{
	BorderColor = 4100,
	MinLod = 33082,
	MaxLod = 33083,
	LodBias = 34049,
}

internal enum HintMode : uint
{
	DontCare = 4352,
	Fastest = 4353,
	Nicest = 4354,
}

internal enum VertexAttribIType : uint
{
	Byte = 5120,
	UnsignedByte = 5121,
	Short = 5122,
	UnsignedShort = 5123,
	Int = 5124,
	UnsignedInt = 5125,
}

internal enum WeightPointerTypeARB : uint
{
	Byte = 5120,
	UnsignedByte = 5121,
	Short = 5122,
	UnsignedShort = 5123,
	Int = 5124,
	UnsignedInt = 5125,
	Float = 5126,
	Double = 5130,
}

internal enum TangentPointerTypeEXT : uint
{
	Byte = 5120,
	Short = 5122,
	Int = 5124,
	Float = 5126,
	Double = 5130,
}

internal enum BinormalPointerTypeEXT : uint
{
	Byte = 5120,
	Short = 5122,
	Int = 5124,
	Float = 5126,
	Double = 5130,
}

internal enum ColorPointerType : uint
{
	Byte = 5120,
	UnsignedByte = 5121,
	Short = 5122,
	UnsignedShort = 5123,
	Int = 5124,
	UnsignedInt = 5125,
	Float = 5126,
	Double = 5130,
}

internal enum ListNameType : uint
{
	Byte = 5120,
	UnsignedByte = 5121,
	Short = 5122,
	UnsignedShort = 5123,
	Int = 5124,
	UnsignedInt = 5125,
	Float = 5126,
}

internal enum NormalPointerType : uint
{
	Byte = 5120,
	Short = 5122,
	Int = 5124,
	Float = 5126,
	Double = 5130,
}

internal enum PixelType : uint
{
	Byte = 5120,
	UnsignedByte = 5121,
	Short = 5122,
	UnsignedShort = 5123,
	Int = 5124,
	UnsignedInt = 5125,
	Float = 5126,
	UnsignedByte332 = 32818,
	UnsignedShort4444 = 32819,
	UnsignedShort5551 = 32820,
	UnsignedInt8888 = 32821,
	UnsignedInt1010102 = 32822,
	UnsignedByte233Rev = 33634,
	UnsignedShort565 = 33635,
	UnsignedShort565Rev = 33636,
	UnsignedShort4444Rev = 33637,
	UnsignedShort1555Rev = 33638,
	UnsignedInt8888Rev = 33639,
	UnsignedInt2101010Rev = 33640,
	UnsignedInt10f11f11fRev = 35899,
	UnsignedInt5999Rev = 35902,
	Float32UnsignedInt248Rev = 36269,
	UnsignedInt248 = 34042,
	HalfFloat = 5131,
}

internal enum VertexAttribType : uint
{
	Byte = 5120,
	UnsignedByte = 5121,
	Short = 5122,
	UnsignedShort = 5123,
	Int = 5124,
	UnsignedInt = 5125,
	Float = 5126,
	Double = 5130,
	UnsignedInt2101010Rev = 33640,
	UnsignedInt10f11f11fRev = 35899,
	HalfFloat = 5131,
	Int2101010Rev = 36255,
	Fixed = 5132,
}

internal enum VertexAttribPointerType : uint
{
	Byte = 5120,
	UnsignedByte = 5121,
	Short = 5122,
	UnsignedShort = 5123,
	Int = 5124,
	UnsignedInt = 5125,
	Float = 5126,
	Double = 5130,
	UnsignedInt2101010Rev = 33640,
	UnsignedInt10f11f11fRev = 35899,
	HalfFloat = 5131,
	Int2101010Rev = 36255,
	Fixed = 5132,
}

internal enum ScalarType : uint
{
	Byte = 5121,
	Short = 5123,
	Int = 5125,
}

internal enum ReplacementCodeTypeSUN : uint
{
	Byte = 5121,
	Short = 5123,
	Int = 5125,
}

internal enum ElementPointerTypeATI : uint
{
	Byte = 5121,
	Short = 5123,
	Int = 5125,
}

internal enum MatrixIndexPointerTypeARB : uint
{
	Byte = 5121,
	Short = 5123,
	Int = 5125,
}

internal enum DrawElementsType : uint
{
	Byte = 5121,
	Short = 5123,
	Int = 5125,
}

internal enum SecondaryColorPointerTypeIBM : uint
{
	Short = 5122,
	Int = 5124,
	Float = 5126,
	Double = 5130,
}

internal enum IndexPointerType : uint
{
	Short = 5122,
	Int = 5124,
	Float = 5126,
	Double = 5130,
}

internal enum TexCoordPointerType : uint
{
	Short = 5122,
	Int = 5124,
	Float = 5126,
	Double = 5130,
}

internal enum VertexPointerType : uint
{
	Short = 5122,
	Int = 5124,
	Float = 5126,
	Double = 5130,
}

internal enum PixelFormat : uint
{
	UnsignedShort = 5123,
	UnsignedInt = 5125,
	StencilIndex = 6401,
	DepthComponent = 6402,
	Red = 6403,
	Green = 6404,
	Blue = 6405,
	Alpha = 6406,
	Rgb = 6407,
	Rgba = 6408,
	Bgr = 32992,
	Bgra = 32993,
	RedInteger = 36244,
	GreenInteger = 36245,
	BlueInteger = 36246,
	RgbInteger = 36248,
	RgbaInteger = 36249,
	BgrInteger = 36250,
	BgraInteger = 36251,
	DepthStencil = 34041,
	Rg = 33319,
	RgInteger = 33320,
}

internal enum AttributeType : uint
{
	Int = 5124,
	UnsignedInt = 5125,
	Float = 5126,
	Double = 5130,
	FloatVec2 = 35664,
	FloatVec3 = 35665,
	FloatVec4 = 35666,
	IntVec2 = 35667,
	IntVec3 = 35668,
	IntVec4 = 35669,
	Bool = 35670,
	BoolVec2 = 35671,
	BoolVec3 = 35672,
	BoolVec4 = 35673,
	FloatMat2 = 35674,
	FloatMat3 = 35675,
	FloatMat4 = 35676,
	Sampler1d = 35677,
	Sampler2d = 35678,
	Sampler3d = 35679,
	SamplerCube = 35680,
	Sampler1dShadow = 35681,
	Sampler2dShadow = 35682,
	FloatMat2x3 = 35685,
	FloatMat2x4 = 35686,
	FloatMat3x2 = 35687,
	FloatMat3x4 = 35688,
	FloatMat4x2 = 35689,
	FloatMat4x3 = 35690,
	Sampler1dArrayShadow = 36291,
	Sampler2dArrayShadow = 36292,
	SamplerCubeShadow = 36293,
	UnsignedIntVec2 = 36294,
	UnsignedIntVec3 = 36295,
	UnsignedIntVec4 = 36296,
	IntSampler1d = 36297,
	IntSampler2d = 36298,
	IntSampler3d = 36299,
	IntSamplerCube = 36300,
	IntSampler1dArray = 36302,
	IntSampler2dArray = 36303,
	UnsignedIntSampler1d = 36305,
	UnsignedIntSampler2d = 36306,
	UnsignedIntSampler3d = 36307,
	UnsignedIntSamplerCube = 36308,
	UnsignedIntSampler1dArray = 36310,
	UnsignedIntSampler2dArray = 36311,
	Sampler2dRect = 35683,
	Sampler2dRectShadow = 35684,
	SamplerBuffer = 36290,
	IntSampler2dRect = 36301,
	IntSamplerBuffer = 36304,
	UnsignedIntSampler2dRect = 36309,
	UnsignedIntSamplerBuffer = 36312,
	Sampler2dMultisample = 37128,
	IntSampler2dMultisample = 37129,
	UnsignedIntSampler2dMultisample = 37130,
	Sampler2dMultisampleArray = 37131,
	IntSampler2dMultisampleArray = 37132,
	UnsignedIntSampler2dMultisampleArray = 37133,
	SamplerCubeMapArray = 36876,
	SamplerCubeMapArrayShadow = 36877,
	IntSamplerCubeMapArray = 36878,
	UnsignedIntSamplerCubeMapArray = 36879,
	DoubleVec2 = 36860,
	DoubleVec3 = 36861,
	DoubleVec4 = 36862,
	DoubleMat2 = 36678,
	DoubleMat3 = 36679,
	DoubleMat4 = 36680,
	DoubleMat2x3 = 36681,
	DoubleMat2x4 = 36682,
	DoubleMat3x2 = 36683,
	DoubleMat3x4 = 36684,
	DoubleMat4x2 = 36685,
	DoubleMat4x3 = 36686,
	Image1d = 36940,
	Image2d = 36941,
	Image3d = 36942,
	Image2dRect = 36943,
	ImageCube = 36944,
	ImageBuffer = 36945,
	Image1dArray = 36946,
	Image2dArray = 36947,
	ImageCubeMapArray = 36948,
	Image2dMultisample = 36949,
	Image2dMultisampleArray = 36950,
	IntImage1d = 36951,
	IntImage2d = 36952,
	IntImage3d = 36953,
	IntImage2dRect = 36954,
	IntImageCube = 36955,
	IntImageBuffer = 36956,
	IntImage1dArray = 36957,
	IntImage2dArray = 36958,
	IntImageCubeMapArray = 36959,
	IntImage2dMultisample = 36960,
	IntImage2dMultisampleArray = 36961,
	UnsignedIntImage1d = 36962,
	UnsignedIntImage2d = 36963,
	UnsignedIntImage3d = 36964,
	UnsignedIntImage2dRect = 36965,
	UnsignedIntImageCube = 36966,
	UnsignedIntImageBuffer = 36967,
	UnsignedIntImage1dArray = 36968,
	UnsignedIntImage2dArray = 36969,
	UnsignedIntImageCubeMapArray = 36970,
	UnsignedIntImage2dMultisample = 36971,
	UnsignedIntImage2dMultisampleArray = 36972,
}

internal enum UniformType : uint
{
	Int = 5124,
	UnsignedInt = 5125,
	Float = 5126,
	Double = 5130,
	FloatVec2 = 35664,
	FloatVec3 = 35665,
	FloatVec4 = 35666,
	IntVec2 = 35667,
	IntVec3 = 35668,
	IntVec4 = 35669,
	Bool = 35670,
	BoolVec2 = 35671,
	BoolVec3 = 35672,
	BoolVec4 = 35673,
	FloatMat2 = 35674,
	FloatMat3 = 35675,
	FloatMat4 = 35676,
	Sampler1d = 35677,
	Sampler2d = 35678,
	Sampler3d = 35679,
	SamplerCube = 35680,
	Sampler1dShadow = 35681,
	Sampler2dShadow = 35682,
	FloatMat2x3 = 35685,
	FloatMat2x4 = 35686,
	FloatMat3x2 = 35687,
	FloatMat3x4 = 35688,
	FloatMat4x2 = 35689,
	FloatMat4x3 = 35690,
	Sampler1dArray = 36288,
	Sampler2dArray = 36289,
	Sampler1dArrayShadow = 36291,
	Sampler2dArrayShadow = 36292,
	SamplerCubeShadow = 36293,
	UnsignedIntVec2 = 36294,
	UnsignedIntVec3 = 36295,
	UnsignedIntVec4 = 36296,
	IntSampler1d = 36297,
	IntSampler2d = 36298,
	IntSampler3d = 36299,
	IntSamplerCube = 36300,
	IntSampler1dArray = 36302,
	IntSampler2dArray = 36303,
	UnsignedIntSampler1d = 36305,
	UnsignedIntSampler2d = 36306,
	UnsignedIntSampler3d = 36307,
	UnsignedIntSamplerCube = 36308,
	UnsignedIntSampler1dArray = 36310,
	UnsignedIntSampler2dArray = 36311,
	Sampler2dRect = 35683,
	Sampler2dRectShadow = 35684,
	SamplerBuffer = 36290,
	IntSampler2dRect = 36301,
	IntSamplerBuffer = 36304,
	UnsignedIntSampler2dRect = 36309,
	UnsignedIntSamplerBuffer = 36312,
	Sampler2dMultisample = 37128,
	IntSampler2dMultisample = 37129,
	UnsignedIntSampler2dMultisample = 37130,
	Sampler2dMultisampleArray = 37131,
	IntSampler2dMultisampleArray = 37132,
	UnsignedIntSampler2dMultisampleArray = 37133,
	SamplerCubeMapArray = 36876,
	SamplerCubeMapArrayShadow = 36877,
	IntSamplerCubeMapArray = 36878,
	UnsignedIntSamplerCubeMapArray = 36879,
	DoubleVec2 = 36860,
	DoubleVec3 = 36861,
	DoubleVec4 = 36862,
	DoubleMat2 = 36678,
	DoubleMat3 = 36679,
	DoubleMat4 = 36680,
	DoubleMat2x3 = 36681,
	DoubleMat2x4 = 36682,
	DoubleMat3x2 = 36683,
	DoubleMat3x4 = 36684,
	DoubleMat4x2 = 36685,
	DoubleMat4x3 = 36686,
}

internal enum MapTypeNV : uint
{
	Float = 5126,
	Double = 5130,
}

internal enum VertexWeightPointerTypeEXT : uint
{
	Float = 5126,
}

internal enum FogCoordinatePointerType : uint
{
	Float = 5126,
	Double = 5130,
}

internal enum FogPointerTypeEXT : uint
{
	Float = 5126,
	Double = 5130,
}

internal enum FogPointerTypeIBM : uint
{
	Float = 5126,
	Double = 5130,
}

internal enum LogicOp : uint
{
	Clear = 5376,
	And = 5377,
	AndReverse = 5378,
	Copy = 5379,
	AndInverted = 5380,
	Noop = 5381,
	Xor = 5382,
	Or = 5383,
	Nor = 5384,
	Equiv = 5385,
	Invert = 5386,
	OrReverse = 5387,
	CopyInverted = 5388,
	OrInverted = 5389,
	Nand = 5390,
	Set = 5391,
}

internal enum PathFillMode : uint
{
	Invert = 5386,
}

internal enum MatrixMode : uint
{
	Texture = 5890,
}

internal enum BufferType : uint
{
	Color = 6144,
	Depth = 6145,
	Stencil = 6146,
}

internal enum PixelCopyType : uint
{
	Color = 6144,
	Depth = 6145,
	Stencil = 6146,
}

internal enum InvalidateFramebufferAttachment : uint
{
	Color = 6144,
	Depth = 6145,
	Stencil = 6146,
	DepthStencilAttachment = 33306,
	ColorAttachment0 = 36064,
	ColorAttachment1 = 36065,
	ColorAttachment2 = 36066,
	ColorAttachment3 = 36067,
	ColorAttachment4 = 36068,
	ColorAttachment5 = 36069,
	ColorAttachment6 = 36070,
	ColorAttachment7 = 36071,
	ColorAttachment8 = 36072,
	ColorAttachment9 = 36073,
	ColorAttachment10 = 36074,
	ColorAttachment11 = 36075,
	ColorAttachment12 = 36076,
	ColorAttachment13 = 36077,
	ColorAttachment14 = 36078,
	ColorAttachment15 = 36079,
	ColorAttachment16 = 36080,
	ColorAttachment17 = 36081,
	ColorAttachment18 = 36082,
	ColorAttachment19 = 36083,
	ColorAttachment20 = 36084,
	ColorAttachment21 = 36085,
	ColorAttachment22 = 36086,
	ColorAttachment23 = 36087,
	ColorAttachment24 = 36088,
	ColorAttachment25 = 36089,
	ColorAttachment26 = 36090,
	ColorAttachment27 = 36091,
	ColorAttachment28 = 36092,
	ColorAttachment29 = 36093,
	ColorAttachment30 = 36094,
	ColorAttachment31 = 36095,
	DepthAttachment = 36096,
}

internal enum InternalFormat : uint
{
	StencilIndex = 6401,
	DepthComponent = 6402,
	Red = 6403,
	Rgb = 6407,
	Rgba = 6408,
	R3G3B2 = 10768,
	Rgb4 = 32847,
	Rgb5 = 32848,
	Rgb8 = 32849,
	Rgb10 = 32850,
	Rgb12 = 32851,
	Rgb16 = 32852,
	Rgba2 = 32853,
	Rgba4 = 32854,
	Rgb5A1 = 32855,
	Rgba8 = 32856,
	Rgb10A2 = 32857,
	Rgba12 = 32858,
	Rgba16 = 32859,
	CompressedRgb = 34029,
	CompressedRgba = 34030,
	DepthComponent16 = 33189,
	DepthComponent24 = 33190,
	DepthComponent32 = 33191,
	Srgb = 35904,
	Srgb8 = 35905,
	SrgbAlpha = 35906,
	Srgb8Alpha8 = 35907,
	CompressedSrgb = 35912,
	CompressedSrgbAlpha = 35913,
	CompressedRed = 33317,
	CompressedRg = 33318,
	Rgba32f = 34836,
	Rgb32f = 34837,
	Rgba16f = 34842,
	Rgb16f = 34843,
	R11fG11fB10f = 35898,
	Rgb9E5 = 35901,
	Rgba32ui = 36208,
	Rgb32ui = 36209,
	Rgba16ui = 36214,
	Rgb16ui = 36215,
	Rgba8ui = 36220,
	Rgb8ui = 36221,
	Rgba32i = 36226,
	Rgb32i = 36227,
	Rgba16i = 36232,
	Rgb16i = 36233,
	Rgba8i = 36238,
	Rgb8i = 36239,
	DepthComponent32f = 36012,
	Depth32fStencil8 = 36013,
	DepthStencil = 34041,
	Depth24Stencil8 = 35056,
	StencilIndex1 = 36166,
	StencilIndex4 = 36167,
	StencilIndex8 = 36168,
	StencilIndex16 = 36169,
	CompressedRedRgtc1 = 36283,
	CompressedSignedRedRgtc1 = 36284,
	CompressedRgRgtc2 = 36285,
	CompressedSignedRgRgtc2 = 36286,
	Rg = 33319,
	R8 = 33321,
	R16 = 33322,
	Rg8 = 33323,
	Rg16 = 33324,
	R16f = 33325,
	R32f = 33326,
	Rg16f = 33327,
	Rg32f = 33328,
	R8i = 33329,
	R8ui = 33330,
	R16i = 33331,
	R16ui = 33332,
	R32i = 33333,
	R32ui = 33334,
	Rg8i = 33335,
	Rg8ui = 33336,
	Rg16i = 33337,
	Rg16ui = 33338,
	Rg32i = 33339,
	Rg32ui = 33340,
	R8Snorm = 36756,
	Rg8Snorm = 36757,
	Rgb8Snorm = 36758,
	Rgba8Snorm = 36759,
	R16Snorm = 36760,
	Rg16Snorm = 36761,
	Rgb16Snorm = 36762,
	Rgba16Snorm = 36763,
	Rgb10A2ui = 36975,
	Rgb565 = 36194,
	CompressedRgbaBptcUnorm = 36492,
	CompressedSrgbAlphaBptcUnorm = 36493,
	CompressedRgbBptcSignedFloat = 36494,
	CompressedRgbBptcUnsignedFloat = 36495,
	CompressedRgb8Etc2 = 37492,
	CompressedSrgb8Etc2 = 37493,
	CompressedRgb8PunchthroughAlpha1Etc2 = 37494,
	CompressedSrgb8PunchthroughAlpha1Etc2 = 37495,
	CompressedRgba8Etc2Eac = 37496,
	CompressedSrgb8Alpha8Etc2Eac = 37497,
	CompressedR11Eac = 37488,
	CompressedSignedR11Eac = 37489,
	CompressedRg11Eac = 37490,
	CompressedSignedRg11Eac = 37491,
}

internal enum DepthStencilTextureMode : uint
{
	StencilIndex = 6401,
	DepthComponent = 6402,
}

internal enum CombinerComponentUsageNV : uint
{
	Blue = 6405,
	Alpha = 6406,
	Rgb = 6407,
}

internal enum CombinerPortionNV : uint
{
	Alpha = 6406,
	Rgb = 6407,
}

internal enum PolygonMode : uint
{
	Point = 6912,
	Line = 6913,
	Fill = 6914,
}

internal enum MeshMode1 : uint
{
	Point = 6912,
	Line = 6913,
}

internal enum MeshMode2 : uint
{
	Point = 6912,
	Line = 6913,
	Fill = 6914,
}

internal enum LightEnvModeSGIX : uint
{
	Replace = 7681,
}

internal enum StringName : uint
{
	Vendor = 7936,
	Renderer = 7937,
	Version = 7938,
	Extensions = 7939,
	ShadingLanguageVersion = 35724,
}

internal enum BlitFramebufferFilter : uint
{
	Nearest = 9728,
	Linear = 9729,
}

internal enum TextureMagFilter : uint
{
	Nearest = 9728,
	Linear = 9729,
}

internal enum TextureMinFilter : uint
{
	Nearest = 9728,
	Linear = 9729,
	NearestMipmapNearest = 9984,
	LinearMipmapNearest = 9985,
	NearestMipmapLinear = 9986,
	LinearMipmapLinear = 9987,
}

internal enum FogMode : uint
{
	Linear = 9729,
}

internal enum TextureWrapMode : uint
{
	LinearMipmapLinear = 9987,
	Repeat = 10497,
	ClampToEdge = 33071,
	ClampToBorder = 33069,
	MirroredRepeat = 33648,
}

internal enum SamplerParameterI : uint
{
	MagFilter = 10240,
	MinFilter = 10241,
	WrapS = 10242,
	WrapT = 10243,
	WrapR = 32882,
	CompareMode = 34892,
	CompareFunc = 34893,
}

internal enum VertexAttribLType : uint
{
	Double = 5130,
}

internal enum SizedInternalFormat : uint
{
	R3G3B2 = 10768,
	Rgb4 = 32847,
	Rgb5 = 32848,
	Rgb8 = 32849,
	Rgb10 = 32850,
	Rgb12 = 32851,
	Rgb16 = 32852,
	Rgba2 = 32853,
	Rgba4 = 32854,
	Rgb5A1 = 32855,
	Rgba8 = 32856,
	Rgb10A2 = 32857,
	Rgba12 = 32858,
	Rgba16 = 32859,
	DepthComponent16 = 33189,
	DepthComponent24 = 33190,
	DepthComponent32 = 33191,
	Srgb8 = 35905,
	Srgb8Alpha8 = 35907,
	Rgba32f = 34836,
	Rgb32f = 34837,
	Rgba16f = 34842,
	Rgb16f = 34843,
	R11fG11fB10f = 35898,
	Rgb9E5 = 35901,
	Rgba32ui = 36208,
	Rgb32ui = 36209,
	Rgba16ui = 36214,
	Rgb16ui = 36215,
	Rgba8ui = 36220,
	Rgb8ui = 36221,
	Rgba32i = 36226,
	Rgb32i = 36227,
	Rgba16i = 36232,
	Rgb16i = 36233,
	Rgba8i = 36238,
	Rgb8i = 36239,
	DepthComponent32f = 36012,
	Depth32fStencil8 = 36013,
	Depth24Stencil8 = 35056,
	StencilIndex1 = 36166,
	StencilIndex4 = 36167,
	StencilIndex8 = 36168,
	StencilIndex16 = 36169,
	CompressedRedRgtc1 = 36283,
	CompressedSignedRedRgtc1 = 36284,
	CompressedRgRgtc2 = 36285,
	CompressedSignedRgRgtc2 = 36286,
	R8 = 33321,
	R16 = 33322,
	Rg8 = 33323,
	Rg16 = 33324,
	R16f = 33325,
	R32f = 33326,
	Rg16f = 33327,
	Rg32f = 33328,
	R8i = 33329,
	R8ui = 33330,
	R16i = 33331,
	R16ui = 33332,
	R32i = 33333,
	R32ui = 33334,
	Rg8i = 33335,
	Rg8ui = 33336,
	Rg16i = 33337,
	Rg16ui = 33338,
	Rg32i = 33339,
	Rg32ui = 33340,
	R8Snorm = 36756,
	Rg8Snorm = 36757,
	Rgb8Snorm = 36758,
	Rgba8Snorm = 36759,
	R16Snorm = 36760,
	Rg16Snorm = 36761,
	Rgb16Snorm = 36762,
	Rgba16Snorm = 36763,
	Rgb10A2ui = 36975,
	Rgb565 = 36194,
	CompressedRgbaBptcUnorm = 36492,
	CompressedSrgbAlphaBptcUnorm = 36493,
	CompressedRgbBptcSignedFloat = 36494,
	CompressedRgbBptcUnsignedFloat = 36495,
	CompressedRgb8Etc2 = 37492,
	CompressedSrgb8Etc2 = 37493,
	CompressedRgb8PunchthroughAlpha1Etc2 = 37494,
	CompressedSrgb8PunchthroughAlpha1Etc2 = 37495,
	CompressedRgba8Etc2Eac = 37496,
	CompressedSrgb8Alpha8Etc2Eac = 37497,
	CompressedR11Eac = 37488,
	CompressedSignedR11Eac = 37489,
	CompressedRg11Eac = 37490,
	CompressedSignedRg11Eac = 37491,
}

internal enum TextureUnit : uint
{
	Texture0 = 33984,
	Texture1 = 33985,
	Texture2 = 33986,
	Texture3 = 33987,
	Texture4 = 33988,
	Texture5 = 33989,
	Texture6 = 33990,
	Texture7 = 33991,
	Texture8 = 33992,
	Texture9 = 33993,
	Texture10 = 33994,
	Texture11 = 33995,
	Texture12 = 33996,
	Texture13 = 33997,
	Texture14 = 33998,
	Texture15 = 33999,
	Texture16 = 34000,
	Texture17 = 34001,
	Texture18 = 34002,
	Texture19 = 34003,
	Texture20 = 34004,
	Texture21 = 34005,
	Texture22 = 34006,
	Texture23 = 34007,
	Texture24 = 34008,
	Texture25 = 34009,
	Texture26 = 34010,
	Texture27 = 34011,
	Texture28 = 34012,
	Texture29 = 34013,
	Texture30 = 34014,
	Texture31 = 34015,
}

internal enum FragmentShaderTextureSourceATI : uint
{
	Texture0 = 33984,
	Texture1 = 33985,
	Texture2 = 33986,
	Texture3 = 33987,
	Texture4 = 33988,
	Texture5 = 33989,
	Texture6 = 33990,
	Texture7 = 33991,
	Texture8 = 33992,
	Texture9 = 33993,
	Texture10 = 33994,
	Texture11 = 33995,
	Texture12 = 33996,
	Texture13 = 33997,
	Texture14 = 33998,
	Texture15 = 33999,
	Texture16 = 34000,
	Texture17 = 34001,
	Texture18 = 34002,
	Texture19 = 34003,
	Texture20 = 34004,
	Texture21 = 34005,
	Texture22 = 34006,
	Texture23 = 34007,
	Texture24 = 34008,
	Texture25 = 34009,
	Texture26 = 34010,
	Texture27 = 34011,
	Texture28 = 34012,
	Texture29 = 34013,
	Texture30 = 34014,
	Texture31 = 34015,
}

internal enum InternalFormatPName : uint
{
	Samples = 32937,
	TextureCompressed = 34465,
	NumSampleCounts = 37760,
	ImageFormatCompatibilityType = 37063,
	InternalformatSupported = 33391,
	InternalformatPreferred = 33392,
	InternalformatRedSize = 33393,
	InternalformatGreenSize = 33394,
	InternalformatBlueSize = 33395,
	InternalformatAlphaSize = 33396,
	InternalformatDepthSize = 33397,
	InternalformatStencilSize = 33398,
	InternalformatSharedSize = 33399,
	InternalformatRedType = 33400,
	InternalformatGreenType = 33401,
	InternalformatBlueType = 33402,
	InternalformatAlphaType = 33403,
	InternalformatDepthType = 33404,
	InternalformatStencilType = 33405,
	MaxWidth = 33406,
	MaxHeight = 33407,
	MaxDepth = 33408,
	MaxLayers = 33409,
	ColorComponents = 33411,
	ColorRenderable = 33414,
	DepthRenderable = 33415,
	StencilRenderable = 33416,
	FramebufferRenderable = 33417,
	FramebufferRenderableLayered = 33418,
	FramebufferBlend = 33419,
	ReadPixels = 33420,
	ReadPixelsFormat = 33421,
	ReadPixelsType = 33422,
	TextureImageFormat = 33423,
	TextureImageType = 33424,
	GetTextureImageFormat = 33425,
	GetTextureImageType = 33426,
	Mipmap = 33427,
	AutoGenerateMipmap = 33429,
	ColorEncoding = 33430,
	SrgbRead = 33431,
	SrgbWrite = 33432,
	Filter = 33434,
	VertexTexture = 33435,
	TessControlTexture = 33436,
	TessEvaluationTexture = 33437,
	GeometryTexture = 33438,
	FragmentTexture = 33439,
	ComputeTexture = 33440,
	TextureShadow = 33441,
	TextureGather = 33442,
	TextureGatherShadow = 33443,
	ShaderImageLoad = 33444,
	ShaderImageStore = 33445,
	ShaderImageAtomic = 33446,
	ImageTexelSize = 33447,
	ImageCompatibilityClass = 33448,
	ImagePixelFormat = 33449,
	ImagePixelType = 33450,
	SimultaneousTextureAndDepthTest = 33452,
	SimultaneousTextureAndStencilTest = 33453,
	SimultaneousTextureAndDepthWrite = 33454,
	SimultaneousTextureAndStencilWrite = 33455,
	TextureCompressedBlockWidth = 33457,
	TextureCompressedBlockHeight = 33458,
	TextureCompressedBlockSize = 33459,
	ClearBuffer = 33460,
	TextureView = 33461,
	ViewCompatibilityClass = 33462,
	ClearTexture = 37733,
}

internal enum PointParameterNameARB : uint
{
	Size = 33064,
}

internal enum TextureEnvParameter : uint
{
	TextureLodBias = 34049,
	Src1Alpha = 34185,
}

internal enum BlendEquationModeEXT : uint
{
	FuncAdd = 32774,
	FuncReverseSubtract = 32779,
	FuncSubtract = 32778,
	Min = 32775,
	Max = 32776,
}

internal enum BufferPNameARB : uint
{
	Size = 34660,
	Usage = 34661,
	Access = 35003,
	Mapped = 35004,
	AccessFlags = 37151,
	MapLength = 37152,
	MapOffset = 37153,
	ImmutableStorage = 33311,
	StorageFlags = 33312,
}

internal enum QueryParameterName : uint
{
	QueryCounterBits = 34916,
	CurrentQuery = 34917,
}

internal enum QueryObjectParameterName : uint
{
	Result = 34918,
	ResultAvailable = 34919,
	ResultNoWait = 37268,
	Target = 33514,
}

internal enum CopyBufferSubDataTarget : uint
{
	Array = 34962,
	ElementArray = 34963,
	PixelPack = 35051,
	PixelUnpack = 35052,
	TransformFeedback = 35982,
	Texture = 35882,
	CopyRead = 36662,
	CopyWrite = 36663,
	Uniform = 35345,
	DrawIndirect = 36671,
	AtomicCounter = 37568,
	DispatchIndirect = 37102,
	ShaderStorage = 37074,
	Query = 37266,
}

internal enum BufferTarget : uint
{
	Array = 34962,
	ElementArray = 34963,
	PixelPack = 35051,
	PixelUnpack = 35052,
	TransformFeedback = 35982,
	Texture = 35882,
	CopyRead = 36662,
	CopyWrite = 36663,
	Uniform = 35345,
	DrawIndirect = 36671,
	AtomicCounter = 37568,
	DispatchIndirect = 37102,
	ShaderStorage = 37074,
	Query = 37266,
}

internal enum BufferStorageTarget : uint
{
	Array = 34962,
	ElementArray = 34963,
	PixelPack = 35051,
	PixelUnpack = 35052,
	TransformFeedback = 35982,
	Texture = 35882,
	CopyRead = 36662,
	CopyWrite = 36663,
	Uniform = 35345,
	DrawIndirect = 36671,
	AtomicCounter = 37568,
	DispatchIndirect = 37102,
	ShaderStorage = 37074,
	Query = 37266,
}

internal enum VertexAttribEnum : uint
{
	VertexAttribArrayBufferBinding = 34975,
	VertexAttribArrayEnabled = 34338,
	VertexAttribArraySize = 34339,
	VertexAttribArrayStride = 34340,
	VertexAttribArrayType = 34341,
	CurrentVertexAttrib = 34342,
	VertexAttribArrayNormalized = 34922,
	VertexAttribArrayInteger = 35069,
	VertexAttribArrayDivisor = 35070,
}

internal enum VertexAttribPropertyARB : uint
{
	VertexAttribArrayBufferBinding = 34975,
	VertexAttribArrayEnabled = 34338,
	VertexAttribArraySize = 34339,
	VertexAttribArrayStride = 34340,
	VertexAttribArrayType = 34341,
	CurrentVertexAttrib = 34342,
	VertexAttribArrayNormalized = 34922,
	VertexAttribArrayInteger = 35069,
	VertexAttribArrayDivisor = 35070,
	VertexAttribArrayLong = 34638,
	VertexAttribBinding = 33492,
	VertexAttribRelativeOffset = 33493,
}

internal enum BufferAccessARB : uint
{
	ReadOnly = 35000,
	WriteOnly = 35001,
	ReadWrite = 35002,
}

internal enum BufferPointerNameARB : uint
{
	Pointer = 35005,
}

internal enum VertexBufferObjectUsage : uint
{
	StreamDraw = 35040,
	StreamRead = 35041,
	StreamCopy = 35042,
	StaticDraw = 35044,
	StaticRead = 35045,
	StaticCopy = 35046,
	DynamicDraw = 35048,
	DynamicRead = 35049,
	DynamicCopy = 35050,
}

internal enum BufferUsage : uint
{
	StreamDraw = 35040,
	StreamRead = 35041,
	StreamCopy = 35042,
	StaticDraw = 35044,
	StaticRead = 35045,
	StaticCopy = 35046,
	DynamicDraw = 35048,
	DynamicRead = 35049,
	DynamicCopy = 35050,
}

internal enum QueryTarget : uint
{
	SamplesPassed = 35092,
	PrimitivesGenerated = 35975,
	TransformFeedbackPrimitivesWritten = 35976,
	AnySamplesPassed = 35887,
	TimeElapsed = 35007,
	AnySamplesPassedConservative = 36202,
}

internal enum VertexArrayPName : uint
{
	ArrayEnabled = 34338,
	ArraySize = 34339,
	ArrayStride = 34340,
	ArrayType = 34341,
	ArrayNormalized = 34922,
	ArrayInteger = 35069,
	ArrayDivisor = 35070,
	ArrayLong = 34638,
	RelativeOffset = 33493,
}

internal enum VertexAttribPointerPropertyARB : uint
{
	Pointer = 34373,
}

internal enum PipelineParameterName : uint
{
	FragmentShader = 35632,
	VertexShader = 35633,
	InfoLogLength = 35716,
	GeometryShader = 36313,
	TessEvaluationShader = 36487,
	TessControlShader = 36488,
	ActiveProgram = 33369,
}

internal enum ShaderType : uint
{
	Fragment = 35632,
	Vertex = 35633,
	Geometry = 36313,
	TessEvaluation = 36487,
	TessControl = 36488,
	Compute = 37305,
}

internal enum ShaderParameterName : uint
{
	ShaderType = 35663,
	DeleteStatus = 35712,
	CompileStatus = 35713,
	InfoLogLength = 35716,
	ShaderSourceLength = 35720,
}

internal enum ProgramPropertyARB : uint
{
	DeleteStatus = 35712,
	LinkStatus = 35714,
	ValidateStatus = 35715,
	InfoLogLength = 35716,
	AttachedShaders = 35717,
	ActiveUniforms = 35718,
	ActiveUniformMaxLength = 35719,
	ActiveAttributes = 35721,
	ActiveAttributeMaxLength = 35722,
	TransformFeedbackVaryingMaxLength = 35958,
	TransformFeedbackBufferMode = 35967,
	TransformFeedbackVaryings = 35971,
	ActiveUniformBlockMaxNameLength = 35381,
	ActiveUniformBlocks = 35382,
	GeometryVerticesOut = 35094,
	GeometryInputType = 35095,
	GeometryOutputType = 35096,
	ProgramBinaryLength = 34625,
	ActiveAtomicCounterBuffers = 37593,
	ComputeWorkGroupSize = 33383,
}

internal enum ClipControlOrigin : uint
{
	Lower = 36001,
	Upper = 36002,
}

internal enum ClipPlaneName : uint
{
	Distance0 = 12288,
	Distance1 = 12289,
	Distance2 = 12290,
	Distance3 = 12291,
	Distance4 = 12292,
	Distance5 = 12293,
	Distance6 = 12294,
	Distance7 = 12295,
}

internal enum ClampColorTargetARB : uint
{
	Color = 35100,
}

internal enum TransformFeedbackPName : uint
{
	BufferStart = 35972,
	BufferSize = 35973,
	BufferBinding = 35983,
	Active = 36388,
	Paused = 36387,
}

internal enum TransformFeedbackBufferMode : uint
{
	Interleaved = 35980,
	Separate = 35981,
}

internal enum ProgramInterface : uint
{
	TransformFeedbackBuffer = 35982,
	Uniform = 37601,
	UniformBlock = 37602,
	ProgramInput = 37603,
	ProgramOutput = 37604,
	BufferVariable = 37605,
	ShaderStorageBlock = 37606,
	VertexSubroutine = 37608,
	TessControlSubroutine = 37609,
	TessEvaluationSubroutine = 37610,
	GeometrySubroutine = 37611,
	FragmentSubroutine = 37612,
	ComputeSubroutine = 37613,
	VertexSubroutineUniform = 37614,
	TessControlSubroutineUniform = 37615,
	TessEvaluationSubroutineUniform = 37616,
	GeometrySubroutineUniform = 37617,
	FragmentSubroutineUniform = 37618,
	ComputeSubroutineUniform = 37619,
	TransformFeedbackVarying = 37620,
}

internal enum ConditionalRenderMode : uint
{
	Wait = 36371,
	NoWait = 36372,
	ByRegionWait = 36373,
	ByRegionNoWait = 36374,
	WaitInverted = 36375,
	NoWaitInverted = 36376,
	ByRegionWaitInverted = 36377,
	ByRegionNoWaitInverted = 36378,
}

internal enum FramebufferAttachmentParameterName : uint
{
	ColorEncoding = 33296,
	ComponentType = 33297,
	RedSize = 33298,
	GreenSize = 33299,
	BlueSize = 33300,
	AlphaSize = 33301,
	DepthSize = 33302,
	StencilSize = 33303,
	ObjectType = 36048,
	ObjectName = 36049,
	TextureLevel = 36050,
	TextureCubeMapFace = 36051,
	TextureLayer = 36052,
	Layered = 36263,
}

internal enum FramebufferStatus : uint
{
	Undefined = 33305,
	Complete = 36053,
	IncompleteAttachment = 36054,
	IncompleteMissingAttachment = 36055,
	IncompleteDrawBuffer = 36059,
	IncompleteReadBuffer = 36060,
	Unsupported = 36061,
	IncompleteMultisample = 36182,
	IncompleteLayerTargets = 36264,
}

internal enum FramebufferAttachment : uint
{
	DepthStencilAttachment = 33306,
	ColorAttachment0 = 36064,
	ColorAttachment1 = 36065,
	ColorAttachment2 = 36066,
	ColorAttachment3 = 36067,
	ColorAttachment4 = 36068,
	ColorAttachment5 = 36069,
	ColorAttachment6 = 36070,
	ColorAttachment7 = 36071,
	ColorAttachment8 = 36072,
	ColorAttachment9 = 36073,
	ColorAttachment10 = 36074,
	ColorAttachment11 = 36075,
	ColorAttachment12 = 36076,
	ColorAttachment13 = 36077,
	ColorAttachment14 = 36078,
	ColorAttachment15 = 36079,
	ColorAttachment16 = 36080,
	ColorAttachment17 = 36081,
	ColorAttachment18 = 36082,
	ColorAttachment19 = 36083,
	ColorAttachment20 = 36084,
	ColorAttachment21 = 36085,
	ColorAttachment22 = 36086,
	ColorAttachment23 = 36087,
	ColorAttachment24 = 36088,
	ColorAttachment25 = 36089,
	ColorAttachment26 = 36090,
	ColorAttachment27 = 36091,
	ColorAttachment28 = 36092,
	ColorAttachment29 = 36093,
	ColorAttachment30 = 36094,
	ColorAttachment31 = 36095,
	DepthAttachment = 36096,
	StencilAttachment = 36128,
}

internal enum FramebufferTarget : uint
{
	Read = 36008,
	Draw = 36009,
	Framebuffer = 36160,
}

internal enum RenderbufferParameterName : uint
{
	Samples = 36011,
	Width = 36162,
	Height = 36163,
	InternalFormat = 36164,
	RedSize = 36176,
	GreenSize = 36177,
	BlueSize = 36178,
	AlphaSize = 36179,
	DepthSize = 36180,
	StencilSize = 36181,
}

internal enum RenderbufferTarget : uint
{
	Renderbuffer = 36161,
}

internal enum MapBufferAccessMask : uint
{
	Read = 1,
	Write = 2,
	InvalidateRange = 4,
	InvalidateBuffer = 8,
	FlushExplicit = 16,
	Unsynchronized = 32,
	Persistent = 64,
	Coherent = 128,
}

internal enum BufferStorageMask : uint
{
	MapRead = 1,
	MapWrite = 2,
	MapPersistent = 64,
	MapCoherent = 128,
	DynamicStorage = 256,
	ClientStorage = 512,
}

internal enum UniformPName : uint
{
	Type = 35383,
	Size = 35384,
	NameLength = 35385,
	BlockIndex = 35386,
	Offset = 35387,
	ArrayStride = 35388,
	MatrixStride = 35389,
	IsRowMajor = 35390,
	AtomicCounterBufferIndex = 37594,
}

internal enum SubroutineParameterName : uint
{
	UniformSize = 35384,
	UniformNameLength = 35385,
	NumCompatibleSubroutines = 36426,
	CompatibleSubroutines = 36427,
}

internal enum UniformBlockPName : uint
{
	Binding = 35391,
	DataSize = 35392,
	NameLength = 35393,
	ActiveUniforms = 35394,
	ActiveUniformIndices = 35395,
	ReferencedByVertexShader = 35396,
	ReferencedByGeometryShader = 35397,
	ReferencedByFragmentShader = 35398,
	ReferencedByTessControlShader = 34032,
	ReferencedByTessEvaluationShader = 34033,
	ReferencedByComputeShader = 37100,
}

internal enum ContextProfileMask : uint
{
	Core = 1,
	Compatibility = 2,
}

internal enum VertexProvokingMode : uint
{
	First = 36429,
	Last = 36430,
}

internal enum SyncParameterName : uint
{
	ObjectType = 37138,
	SyncCondition = 37139,
	SyncStatus = 37140,
	SyncFlags = 37141,
}

internal enum SyncCondition : uint
{
	Complete = 37143,
}

internal enum SyncStatus : uint
{
	AlreadySignaled = 37146,
	TimeoutExpired = 37147,
	ConditionSatisfied = 37148,
	WaitFailed = 37149,
}

internal enum SyncObjectMask : uint
{
	Bit = 1,
}

internal enum GetMultisamplePNameNV : uint
{
	Position = 36432,
}

internal enum QueryCounterTarget : uint
{
	Timestamp = 36392,
}

internal enum ProgramStagePName : uint
{
	Subroutines = 36325,
	SubroutineUniforms = 36326,
	SubroutineUniformLocations = 36423,
	SubroutineMaxLength = 36424,
	SubroutineUniformMaxLength = 36425,
}

internal enum ProgramResourceProperty : uint
{
	NumCompatibleSubroutines = 36426,
	CompatibleSubroutines = 36427,
	Uniform = 37601,
	NameLength = 37625,
	Type = 37626,
	ArraySize = 37627,
	Offset = 37628,
	BlockIndex = 37629,
	ArrayStride = 37630,
	MatrixStride = 37631,
	IsRowMajor = 37632,
	AtomicCounterBufferIndex = 37633,
	BufferBinding = 37634,
	BufferDataSize = 37635,
	NumActiveVariables = 37636,
	ActiveVariables = 37637,
	ReferencedByVertexShader = 37638,
	ReferencedByTessControlShader = 37639,
	ReferencedByTessEvaluationShader = 37640,
	ReferencedByGeometryShader = 37641,
	ReferencedByFragmentShader = 37642,
	ReferencedByComputeShader = 37643,
	TopLevelArraySize = 37644,
	TopLevelArrayStride = 37645,
	Location = 37646,
	LocationIndex = 37647,
	IsPerPatch = 37607,
	LocationComponent = 37706,
	TransformFeedbackBufferIndex = 37707,
	TransformFeedbackBufferStride = 37708,
}

internal enum PatchParameterName : uint
{
	Vertices = 36466,
	DefaultInnerLevel = 36467,
	DefaultOuterLevel = 36468,
}

internal enum BindTransformFeedbackTarget : uint
{
	Feedback = 36386,
}

internal enum PrecisionType : uint
{
	LowFloat = 36336,
	MediumFloat = 36337,
	HighFloat = 36338,
	LowInt = 36339,
	MediumInt = 36340,
	HighInt = 36341,
}

internal enum ProgramParameterPName : uint
{
	BinaryRetrievableHint = 33367,
	Separable = 33368,
}

internal enum UseProgramStageMask : uint
{
	Vertex = 1,
	Fragment = 2,
	Geometry = 4,
	TessControl = 8,
	TessEvaluation = 16,
	All = 4294967295,
	Compute = 32,
}

internal enum AtomicCounterBufferPName : uint
{
	Binding = 37569,
	DataSize = 37572,
	ActiveAtomicCounters = 37573,
	ActiveAtomicCounterIndices = 37574,
	ReferencedByVertexShader = 37575,
	ReferencedByTessControlShader = 37576,
	ReferencedByTessEvaluationShader = 37577,
	ReferencedByGeometryShader = 37578,
	ReferencedByFragmentShader = 37579,
	ReferencedByComputeShader = 37101,
}

internal enum MemoryBarrierMask : uint
{
	VertexAttribArray = 1,
	ElementArray = 2,
	Uniform = 4,
	TextureFetch = 8,
	ShaderImageAccess = 32,
	Command = 64,
	PixelBuffer = 128,
	TextureUpdate = 256,
	BufferUpdate = 512,
	Framebuffer = 1024,
	TransformFeedback = 2048,
	AtomicCounter = 4096,
	All = 4294967295,
	ShaderStorage = 8192,
	ClientMappedBuffer = 16384,
	QueryBuffer = 32768,
}

internal enum FramebufferParameterName : uint
{
	Width = 37648,
	Height = 37649,
	Layers = 37650,
	Samples = 37651,
	FixedSampleLocations = 37652,
}

internal enum ProgramInterfacePName : uint
{
	ActiveResources = 37621,
	MaxNameLength = 37622,
	MaxNumActiveVariables = 37623,
	MaxNumCompatibleSubroutines = 37624,
}

internal enum ClipControlDepth : uint
{
	NegativeOne = 37726,
	Zero = 37727,
}

internal enum ShaderBinaryFormat : uint
{
}


internal static class SpecialNumbers
{
	internal const uint False = 0;
	internal const uint True = 1;
	internal const uint Zero = 0;
	internal const uint One = 1;
	internal const uint None = 0;
	internal const uint NoError = 0;
	internal const uint InvalidIndex = 4294967295;
	internal const ulong TimeoutIgnored = 18446744073709551615;
}

internal static class GL
{

	internal delegate IntPtr LoaderDelegate([MarshalAs(UnmanagedType.LPStr)] string name);
	internal static void Load(LoaderDelegate loader)
	{
		DebugMessageControlInstance = Marshal.GetDelegateForFunctionPointer<DebugMessageControlDelegate>(loader("glDebugMessageControl"));
		DebugMessageInsertInstance = Marshal.GetDelegateForFunctionPointer<DebugMessageInsertDelegate>(loader("glDebugMessageInsert"));
		DebugMessageCallbackInstance = Marshal.GetDelegateForFunctionPointer<DebugMessageCallbackDelegate>(loader("glDebugMessageCallback"));
		GetDebugMessageLogInstance = Marshal.GetDelegateForFunctionPointer<GetDebugMessageLogDelegate>(loader("glGetDebugMessageLog"));
		PushDebugGroupInstance = Marshal.GetDelegateForFunctionPointer<PushDebugGroupDelegate>(loader("glPushDebugGroup"));
		PopDebugGroupInstance = Marshal.GetDelegateForFunctionPointer<PopDebugGroupDelegate>(loader("glPopDebugGroup"));
		ObjectLabelInstance = Marshal.GetDelegateForFunctionPointer<ObjectLabelDelegate>(loader("glObjectLabel"));
		GetObjectLabelInstance = Marshal.GetDelegateForFunctionPointer<GetObjectLabelDelegate>(loader("glGetObjectLabel"));
		ObjectPtrLabelInstance = Marshal.GetDelegateForFunctionPointer<ObjectPtrLabelDelegate>(loader("glObjectPtrLabel"));
		GetObjectPtrLabelInstance = Marshal.GetDelegateForFunctionPointer<GetObjectPtrLabelDelegate>(loader("glGetObjectPtrLabel"));
		DebugMessageControlKHRInstance = Marshal.GetDelegateForFunctionPointer<DebugMessageControlKHRDelegate>(loader("glDebugMessageControlKHR"));
		DebugMessageInsertKHRInstance = Marshal.GetDelegateForFunctionPointer<DebugMessageInsertKHRDelegate>(loader("glDebugMessageInsertKHR"));
		DebugMessageCallbackKHRInstance = Marshal.GetDelegateForFunctionPointer<DebugMessageCallbackKHRDelegate>(loader("glDebugMessageCallbackKHR"));
		GetDebugMessageLogKHRInstance = Marshal.GetDelegateForFunctionPointer<GetDebugMessageLogKHRDelegate>(loader("glGetDebugMessageLogKHR"));
		PushDebugGroupKHRInstance = Marshal.GetDelegateForFunctionPointer<PushDebugGroupKHRDelegate>(loader("glPushDebugGroupKHR"));
		PopDebugGroupKHRInstance = Marshal.GetDelegateForFunctionPointer<PopDebugGroupKHRDelegate>(loader("glPopDebugGroupKHR"));
		ObjectLabelKHRInstance = Marshal.GetDelegateForFunctionPointer<ObjectLabelKHRDelegate>(loader("glObjectLabelKHR"));
		GetObjectLabelKHRInstance = Marshal.GetDelegateForFunctionPointer<GetObjectLabelKHRDelegate>(loader("glGetObjectLabelKHR"));
		ObjectPtrLabelKHRInstance = Marshal.GetDelegateForFunctionPointer<ObjectPtrLabelKHRDelegate>(loader("glObjectPtrLabelKHR"));
		GetObjectPtrLabelKHRInstance = Marshal.GetDelegateForFunctionPointer<GetObjectPtrLabelKHRDelegate>(loader("glGetObjectPtrLabelKHR"));
		GetPointervKHRInstance = Marshal.GetDelegateForFunctionPointer<GetPointervKHRDelegate>(loader("glGetPointervKHR"));
		CullFaceInstance = Marshal.GetDelegateForFunctionPointer<CullFaceDelegate>(loader("glCullFace"));
		FrontFaceInstance = Marshal.GetDelegateForFunctionPointer<FrontFaceDelegate>(loader("glFrontFace"));
		HintInstance = Marshal.GetDelegateForFunctionPointer<HintDelegate>(loader("glHint"));
		LineWidthInstance = Marshal.GetDelegateForFunctionPointer<LineWidthDelegate>(loader("glLineWidth"));
		PointSizeInstance = Marshal.GetDelegateForFunctionPointer<PointSizeDelegate>(loader("glPointSize"));
		PolygonModeInstance = Marshal.GetDelegateForFunctionPointer<PolygonModeDelegate>(loader("glPolygonMode"));
		ScissorInstance = Marshal.GetDelegateForFunctionPointer<ScissorDelegate>(loader("glScissor"));
		TexParameterfInstance = Marshal.GetDelegateForFunctionPointer<TexParameterfDelegate>(loader("glTexParameterf"));
		TexParameterfvInstance = Marshal.GetDelegateForFunctionPointer<TexParameterfvDelegate>(loader("glTexParameterfv"));
		TexParameteriInstance = Marshal.GetDelegateForFunctionPointer<TexParameteriDelegate>(loader("glTexParameteri"));
		TexParameterivInstance = Marshal.GetDelegateForFunctionPointer<TexParameterivDelegate>(loader("glTexParameteriv"));
		TexImage1DInstance = Marshal.GetDelegateForFunctionPointer<TexImage1DDelegate>(loader("glTexImage1D"));
		TexImage2DInstance = Marshal.GetDelegateForFunctionPointer<TexImage2DDelegate>(loader("glTexImage2D"));
		DrawBufferInstance = Marshal.GetDelegateForFunctionPointer<DrawBufferDelegate>(loader("glDrawBuffer"));
		ClearInstance = Marshal.GetDelegateForFunctionPointer<ClearDelegate>(loader("glClear"));
		ClearColorInstance = Marshal.GetDelegateForFunctionPointer<ClearColorDelegate>(loader("glClearColor"));
		ClearStencilInstance = Marshal.GetDelegateForFunctionPointer<ClearStencilDelegate>(loader("glClearStencil"));
		ClearDepthInstance = Marshal.GetDelegateForFunctionPointer<ClearDepthDelegate>(loader("glClearDepth"));
		StencilMaskInstance = Marshal.GetDelegateForFunctionPointer<StencilMaskDelegate>(loader("glStencilMask"));
		ColorMaskInstance = Marshal.GetDelegateForFunctionPointer<ColorMaskDelegate>(loader("glColorMask"));
		DepthMaskInstance = Marshal.GetDelegateForFunctionPointer<DepthMaskDelegate>(loader("glDepthMask"));
		DisableInstance = Marshal.GetDelegateForFunctionPointer<DisableDelegate>(loader("glDisable"));
		EnableInstance = Marshal.GetDelegateForFunctionPointer<EnableDelegate>(loader("glEnable"));
		FinishInstance = Marshal.GetDelegateForFunctionPointer<FinishDelegate>(loader("glFinish"));
		FlushInstance = Marshal.GetDelegateForFunctionPointer<FlushDelegate>(loader("glFlush"));
		BlendFuncInstance = Marshal.GetDelegateForFunctionPointer<BlendFuncDelegate>(loader("glBlendFunc"));
		LogicOpInstance = Marshal.GetDelegateForFunctionPointer<LogicOpDelegate>(loader("glLogicOp"));
		StencilFuncInstance = Marshal.GetDelegateForFunctionPointer<StencilFuncDelegate>(loader("glStencilFunc"));
		StencilOpInstance = Marshal.GetDelegateForFunctionPointer<StencilOpDelegate>(loader("glStencilOp"));
		DepthFuncInstance = Marshal.GetDelegateForFunctionPointer<DepthFuncDelegate>(loader("glDepthFunc"));
		PixelStorefInstance = Marshal.GetDelegateForFunctionPointer<PixelStorefDelegate>(loader("glPixelStoref"));
		PixelStoreiInstance = Marshal.GetDelegateForFunctionPointer<PixelStoreiDelegate>(loader("glPixelStorei"));
		ReadBufferInstance = Marshal.GetDelegateForFunctionPointer<ReadBufferDelegate>(loader("glReadBuffer"));
		ReadPixelsInstance = Marshal.GetDelegateForFunctionPointer<ReadPixelsDelegate>(loader("glReadPixels"));
		GetBooleanvInstance = Marshal.GetDelegateForFunctionPointer<GetBooleanvDelegate>(loader("glGetBooleanv"));
		GetDoublevInstance = Marshal.GetDelegateForFunctionPointer<GetDoublevDelegate>(loader("glGetDoublev"));
		GetErrorInstance = Marshal.GetDelegateForFunctionPointer<GetErrorDelegate>(loader("glGetError"));
		GetFloatvInstance = Marshal.GetDelegateForFunctionPointer<GetFloatvDelegate>(loader("glGetFloatv"));
		GetIntegervInstance = Marshal.GetDelegateForFunctionPointer<GetIntegervDelegate>(loader("glGetIntegerv"));
		GetStringInstance = Marshal.GetDelegateForFunctionPointer<GetStringDelegate>(loader("glGetString"));
		GetTexImageInstance = Marshal.GetDelegateForFunctionPointer<GetTexImageDelegate>(loader("glGetTexImage"));
		GetTexParameterfvInstance = Marshal.GetDelegateForFunctionPointer<GetTexParameterfvDelegate>(loader("glGetTexParameterfv"));
		GetTexParameterivInstance = Marshal.GetDelegateForFunctionPointer<GetTexParameterivDelegate>(loader("glGetTexParameteriv"));
		GetTexLevelParameterfvInstance = Marshal.GetDelegateForFunctionPointer<GetTexLevelParameterfvDelegate>(loader("glGetTexLevelParameterfv"));
		GetTexLevelParameterivInstance = Marshal.GetDelegateForFunctionPointer<GetTexLevelParameterivDelegate>(loader("glGetTexLevelParameteriv"));
		IsEnabledInstance = Marshal.GetDelegateForFunctionPointer<IsEnabledDelegate>(loader("glIsEnabled"));
		DepthRangeInstance = Marshal.GetDelegateForFunctionPointer<DepthRangeDelegate>(loader("glDepthRange"));
		ViewportInstance = Marshal.GetDelegateForFunctionPointer<ViewportDelegate>(loader("glViewport"));
		DrawArraysInstance = Marshal.GetDelegateForFunctionPointer<DrawArraysDelegate>(loader("glDrawArrays"));
		DrawElementsInstance = Marshal.GetDelegateForFunctionPointer<DrawElementsDelegate>(loader("glDrawElements"));
		PolygonOffsetInstance = Marshal.GetDelegateForFunctionPointer<PolygonOffsetDelegate>(loader("glPolygonOffset"));
		CopyTexImage1DInstance = Marshal.GetDelegateForFunctionPointer<CopyTexImage1DDelegate>(loader("glCopyTexImage1D"));
		CopyTexImage2DInstance = Marshal.GetDelegateForFunctionPointer<CopyTexImage2DDelegate>(loader("glCopyTexImage2D"));
		CopyTexSubImage1DInstance = Marshal.GetDelegateForFunctionPointer<CopyTexSubImage1DDelegate>(loader("glCopyTexSubImage1D"));
		CopyTexSubImage2DInstance = Marshal.GetDelegateForFunctionPointer<CopyTexSubImage2DDelegate>(loader("glCopyTexSubImage2D"));
		TexSubImage1DInstance = Marshal.GetDelegateForFunctionPointer<TexSubImage1DDelegate>(loader("glTexSubImage1D"));
		TexSubImage2DInstance = Marshal.GetDelegateForFunctionPointer<TexSubImage2DDelegate>(loader("glTexSubImage2D"));
		BindTextureInstance = Marshal.GetDelegateForFunctionPointer<BindTextureDelegate>(loader("glBindTexture"));
		DeleteTexturesInstance = Marshal.GetDelegateForFunctionPointer<DeleteTexturesDelegate>(loader("glDeleteTextures"));
		GenTexturesInstance = Marshal.GetDelegateForFunctionPointer<GenTexturesDelegate>(loader("glGenTextures"));
		IsTextureInstance = Marshal.GetDelegateForFunctionPointer<IsTextureDelegate>(loader("glIsTexture"));
		DrawRangeElementsInstance = Marshal.GetDelegateForFunctionPointer<DrawRangeElementsDelegate>(loader("glDrawRangeElements"));
		TexImage3DInstance = Marshal.GetDelegateForFunctionPointer<TexImage3DDelegate>(loader("glTexImage3D"));
		TexSubImage3DInstance = Marshal.GetDelegateForFunctionPointer<TexSubImage3DDelegate>(loader("glTexSubImage3D"));
		CopyTexSubImage3DInstance = Marshal.GetDelegateForFunctionPointer<CopyTexSubImage3DDelegate>(loader("glCopyTexSubImage3D"));
		ActiveTextureInstance = Marshal.GetDelegateForFunctionPointer<ActiveTextureDelegate>(loader("glActiveTexture"));
		SampleCoverageInstance = Marshal.GetDelegateForFunctionPointer<SampleCoverageDelegate>(loader("glSampleCoverage"));
		CompressedTexImage3DInstance = Marshal.GetDelegateForFunctionPointer<CompressedTexImage3DDelegate>(loader("glCompressedTexImage3D"));
		CompressedTexImage2DInstance = Marshal.GetDelegateForFunctionPointer<CompressedTexImage2DDelegate>(loader("glCompressedTexImage2D"));
		CompressedTexImage1DInstance = Marshal.GetDelegateForFunctionPointer<CompressedTexImage1DDelegate>(loader("glCompressedTexImage1D"));
		CompressedTexSubImage3DInstance = Marshal.GetDelegateForFunctionPointer<CompressedTexSubImage3DDelegate>(loader("glCompressedTexSubImage3D"));
		CompressedTexSubImage2DInstance = Marshal.GetDelegateForFunctionPointer<CompressedTexSubImage2DDelegate>(loader("glCompressedTexSubImage2D"));
		CompressedTexSubImage1DInstance = Marshal.GetDelegateForFunctionPointer<CompressedTexSubImage1DDelegate>(loader("glCompressedTexSubImage1D"));
		GetCompressedTexImageInstance = Marshal.GetDelegateForFunctionPointer<GetCompressedTexImageDelegate>(loader("glGetCompressedTexImage"));
		BlendFuncSeparateInstance = Marshal.GetDelegateForFunctionPointer<BlendFuncSeparateDelegate>(loader("glBlendFuncSeparate"));
		MultiDrawArraysInstance = Marshal.GetDelegateForFunctionPointer<MultiDrawArraysDelegate>(loader("glMultiDrawArrays"));
		MultiDrawElementsInstance = Marshal.GetDelegateForFunctionPointer<MultiDrawElementsDelegate>(loader("glMultiDrawElements"));
		PointParameterfInstance = Marshal.GetDelegateForFunctionPointer<PointParameterfDelegate>(loader("glPointParameterf"));
		PointParameterfvInstance = Marshal.GetDelegateForFunctionPointer<PointParameterfvDelegate>(loader("glPointParameterfv"));
		PointParameteriInstance = Marshal.GetDelegateForFunctionPointer<PointParameteriDelegate>(loader("glPointParameteri"));
		PointParameterivInstance = Marshal.GetDelegateForFunctionPointer<PointParameterivDelegate>(loader("glPointParameteriv"));
		BlendColorInstance = Marshal.GetDelegateForFunctionPointer<BlendColorDelegate>(loader("glBlendColor"));
		BlendEquationInstance = Marshal.GetDelegateForFunctionPointer<BlendEquationDelegate>(loader("glBlendEquation"));
		GenQueriesInstance = Marshal.GetDelegateForFunctionPointer<GenQueriesDelegate>(loader("glGenQueries"));
		DeleteQueriesInstance = Marshal.GetDelegateForFunctionPointer<DeleteQueriesDelegate>(loader("glDeleteQueries"));
		IsQueryInstance = Marshal.GetDelegateForFunctionPointer<IsQueryDelegate>(loader("glIsQuery"));
		BeginQueryInstance = Marshal.GetDelegateForFunctionPointer<BeginQueryDelegate>(loader("glBeginQuery"));
		EndQueryInstance = Marshal.GetDelegateForFunctionPointer<EndQueryDelegate>(loader("glEndQuery"));
		GetQueryivInstance = Marshal.GetDelegateForFunctionPointer<GetQueryivDelegate>(loader("glGetQueryiv"));
		GetQueryObjectivInstance = Marshal.GetDelegateForFunctionPointer<GetQueryObjectivDelegate>(loader("glGetQueryObjectiv"));
		GetQueryObjectuivInstance = Marshal.GetDelegateForFunctionPointer<GetQueryObjectuivDelegate>(loader("glGetQueryObjectuiv"));
		BindBufferInstance = Marshal.GetDelegateForFunctionPointer<BindBufferDelegate>(loader("glBindBuffer"));
		DeleteBuffersInstance = Marshal.GetDelegateForFunctionPointer<DeleteBuffersDelegate>(loader("glDeleteBuffers"));
		GenBuffersInstance = Marshal.GetDelegateForFunctionPointer<GenBuffersDelegate>(loader("glGenBuffers"));
		IsBufferInstance = Marshal.GetDelegateForFunctionPointer<IsBufferDelegate>(loader("glIsBuffer"));
		BufferDataInstance = Marshal.GetDelegateForFunctionPointer<BufferDataDelegate>(loader("glBufferData"));
		BufferSubDataInstance = Marshal.GetDelegateForFunctionPointer<BufferSubDataDelegate>(loader("glBufferSubData"));
		GetBufferSubDataInstance = Marshal.GetDelegateForFunctionPointer<GetBufferSubDataDelegate>(loader("glGetBufferSubData"));
		MapBufferInstance = Marshal.GetDelegateForFunctionPointer<MapBufferDelegate>(loader("glMapBuffer"));
		UnmapBufferInstance = Marshal.GetDelegateForFunctionPointer<UnmapBufferDelegate>(loader("glUnmapBuffer"));
		GetBufferParameterivInstance = Marshal.GetDelegateForFunctionPointer<GetBufferParameterivDelegate>(loader("glGetBufferParameteriv"));
		GetBufferPointervInstance = Marshal.GetDelegateForFunctionPointer<GetBufferPointervDelegate>(loader("glGetBufferPointerv"));
		BlendEquationSeparateInstance = Marshal.GetDelegateForFunctionPointer<BlendEquationSeparateDelegate>(loader("glBlendEquationSeparate"));
		DrawBuffersInstance = Marshal.GetDelegateForFunctionPointer<DrawBuffersDelegate>(loader("glDrawBuffers"));
		StencilOpSeparateInstance = Marshal.GetDelegateForFunctionPointer<StencilOpSeparateDelegate>(loader("glStencilOpSeparate"));
		StencilFuncSeparateInstance = Marshal.GetDelegateForFunctionPointer<StencilFuncSeparateDelegate>(loader("glStencilFuncSeparate"));
		StencilMaskSeparateInstance = Marshal.GetDelegateForFunctionPointer<StencilMaskSeparateDelegate>(loader("glStencilMaskSeparate"));
		AttachShaderInstance = Marshal.GetDelegateForFunctionPointer<AttachShaderDelegate>(loader("glAttachShader"));
		BindAttribLocationInstance = Marshal.GetDelegateForFunctionPointer<BindAttribLocationDelegate>(loader("glBindAttribLocation"));
		CompileShaderInstance = Marshal.GetDelegateForFunctionPointer<CompileShaderDelegate>(loader("glCompileShader"));
		CreateProgramInstance = Marshal.GetDelegateForFunctionPointer<CreateProgramDelegate>(loader("glCreateProgram"));
		CreateShaderInstance = Marshal.GetDelegateForFunctionPointer<CreateShaderDelegate>(loader("glCreateShader"));
		DeleteProgramInstance = Marshal.GetDelegateForFunctionPointer<DeleteProgramDelegate>(loader("glDeleteProgram"));
		DeleteShaderInstance = Marshal.GetDelegateForFunctionPointer<DeleteShaderDelegate>(loader("glDeleteShader"));
		DetachShaderInstance = Marshal.GetDelegateForFunctionPointer<DetachShaderDelegate>(loader("glDetachShader"));
		DisableVertexAttribArrayInstance = Marshal.GetDelegateForFunctionPointer<DisableVertexAttribArrayDelegate>(loader("glDisableVertexAttribArray"));
		EnableVertexAttribArrayInstance = Marshal.GetDelegateForFunctionPointer<EnableVertexAttribArrayDelegate>(loader("glEnableVertexAttribArray"));
		GetActiveAttribInstance = Marshal.GetDelegateForFunctionPointer<GetActiveAttribDelegate>(loader("glGetActiveAttrib"));
		GetActiveUniformInstance = Marshal.GetDelegateForFunctionPointer<GetActiveUniformDelegate>(loader("glGetActiveUniform"));
		GetAttachedShadersInstance = Marshal.GetDelegateForFunctionPointer<GetAttachedShadersDelegate>(loader("glGetAttachedShaders"));
		GetAttribLocationInstance = Marshal.GetDelegateForFunctionPointer<GetAttribLocationDelegate>(loader("glGetAttribLocation"));
		GetProgramivInstance = Marshal.GetDelegateForFunctionPointer<GetProgramivDelegate>(loader("glGetProgramiv"));
		GetProgramInfoLogInstance = Marshal.GetDelegateForFunctionPointer<GetProgramInfoLogDelegate>(loader("glGetProgramInfoLog"));
		GetShaderivInstance = Marshal.GetDelegateForFunctionPointer<GetShaderivDelegate>(loader("glGetShaderiv"));
		GetShaderInfoLogInstance = Marshal.GetDelegateForFunctionPointer<GetShaderInfoLogDelegate>(loader("glGetShaderInfoLog"));
		GetShaderSourceInstance = Marshal.GetDelegateForFunctionPointer<GetShaderSourceDelegate>(loader("glGetShaderSource"));
		GetUniformLocationInstance = Marshal.GetDelegateForFunctionPointer<GetUniformLocationDelegate>(loader("glGetUniformLocation"));
		GetUniformfvInstance = Marshal.GetDelegateForFunctionPointer<GetUniformfvDelegate>(loader("glGetUniformfv"));
		GetUniformivInstance = Marshal.GetDelegateForFunctionPointer<GetUniformivDelegate>(loader("glGetUniformiv"));
		GetVertexAttribdvInstance = Marshal.GetDelegateForFunctionPointer<GetVertexAttribdvDelegate>(loader("glGetVertexAttribdv"));
		GetVertexAttribfvInstance = Marshal.GetDelegateForFunctionPointer<GetVertexAttribfvDelegate>(loader("glGetVertexAttribfv"));
		GetVertexAttribivInstance = Marshal.GetDelegateForFunctionPointer<GetVertexAttribivDelegate>(loader("glGetVertexAttribiv"));
		GetVertexAttribPointervInstance = Marshal.GetDelegateForFunctionPointer<GetVertexAttribPointervDelegate>(loader("glGetVertexAttribPointerv"));
		IsProgramInstance = Marshal.GetDelegateForFunctionPointer<IsProgramDelegate>(loader("glIsProgram"));
		IsShaderInstance = Marshal.GetDelegateForFunctionPointer<IsShaderDelegate>(loader("glIsShader"));
		LinkProgramInstance = Marshal.GetDelegateForFunctionPointer<LinkProgramDelegate>(loader("glLinkProgram"));
		ShaderSourceInstance = Marshal.GetDelegateForFunctionPointer<ShaderSourceDelegate>(loader("glShaderSource"));
		UseProgramInstance = Marshal.GetDelegateForFunctionPointer<UseProgramDelegate>(loader("glUseProgram"));
		Uniform1fInstance = Marshal.GetDelegateForFunctionPointer<Uniform1fDelegate>(loader("glUniform1f"));
		Uniform2fInstance = Marshal.GetDelegateForFunctionPointer<Uniform2fDelegate>(loader("glUniform2f"));
		Uniform3fInstance = Marshal.GetDelegateForFunctionPointer<Uniform3fDelegate>(loader("glUniform3f"));
		Uniform4fInstance = Marshal.GetDelegateForFunctionPointer<Uniform4fDelegate>(loader("glUniform4f"));
		Uniform1iInstance = Marshal.GetDelegateForFunctionPointer<Uniform1iDelegate>(loader("glUniform1i"));
		Uniform2iInstance = Marshal.GetDelegateForFunctionPointer<Uniform2iDelegate>(loader("glUniform2i"));
		Uniform3iInstance = Marshal.GetDelegateForFunctionPointer<Uniform3iDelegate>(loader("glUniform3i"));
		Uniform4iInstance = Marshal.GetDelegateForFunctionPointer<Uniform4iDelegate>(loader("glUniform4i"));
		Uniform1fvInstance = Marshal.GetDelegateForFunctionPointer<Uniform1fvDelegate>(loader("glUniform1fv"));
		Uniform2fvInstance = Marshal.GetDelegateForFunctionPointer<Uniform2fvDelegate>(loader("glUniform2fv"));
		Uniform3fvInstance = Marshal.GetDelegateForFunctionPointer<Uniform3fvDelegate>(loader("glUniform3fv"));
		Uniform4fvInstance = Marshal.GetDelegateForFunctionPointer<Uniform4fvDelegate>(loader("glUniform4fv"));
		Uniform1ivInstance = Marshal.GetDelegateForFunctionPointer<Uniform1ivDelegate>(loader("glUniform1iv"));
		Uniform2ivInstance = Marshal.GetDelegateForFunctionPointer<Uniform2ivDelegate>(loader("glUniform2iv"));
		Uniform3ivInstance = Marshal.GetDelegateForFunctionPointer<Uniform3ivDelegate>(loader("glUniform3iv"));
		Uniform4ivInstance = Marshal.GetDelegateForFunctionPointer<Uniform4ivDelegate>(loader("glUniform4iv"));
		UniformMatrix2fvInstance = Marshal.GetDelegateForFunctionPointer<UniformMatrix2fvDelegate>(loader("glUniformMatrix2fv"));
		UniformMatrix3fvInstance = Marshal.GetDelegateForFunctionPointer<UniformMatrix3fvDelegate>(loader("glUniformMatrix3fv"));
		UniformMatrix4fvInstance = Marshal.GetDelegateForFunctionPointer<UniformMatrix4fvDelegate>(loader("glUniformMatrix4fv"));
		ValidateProgramInstance = Marshal.GetDelegateForFunctionPointer<ValidateProgramDelegate>(loader("glValidateProgram"));
		VertexAttrib1dInstance = Marshal.GetDelegateForFunctionPointer<VertexAttrib1dDelegate>(loader("glVertexAttrib1d"));
		VertexAttrib1dvInstance = Marshal.GetDelegateForFunctionPointer<VertexAttrib1dvDelegate>(loader("glVertexAttrib1dv"));
		VertexAttrib1fInstance = Marshal.GetDelegateForFunctionPointer<VertexAttrib1fDelegate>(loader("glVertexAttrib1f"));
		VertexAttrib1fvInstance = Marshal.GetDelegateForFunctionPointer<VertexAttrib1fvDelegate>(loader("glVertexAttrib1fv"));
		VertexAttrib1sInstance = Marshal.GetDelegateForFunctionPointer<VertexAttrib1sDelegate>(loader("glVertexAttrib1s"));
		VertexAttrib1svInstance = Marshal.GetDelegateForFunctionPointer<VertexAttrib1svDelegate>(loader("glVertexAttrib1sv"));
		VertexAttrib2dInstance = Marshal.GetDelegateForFunctionPointer<VertexAttrib2dDelegate>(loader("glVertexAttrib2d"));
		VertexAttrib2dvInstance = Marshal.GetDelegateForFunctionPointer<VertexAttrib2dvDelegate>(loader("glVertexAttrib2dv"));
		VertexAttrib2fInstance = Marshal.GetDelegateForFunctionPointer<VertexAttrib2fDelegate>(loader("glVertexAttrib2f"));
		VertexAttrib2fvInstance = Marshal.GetDelegateForFunctionPointer<VertexAttrib2fvDelegate>(loader("glVertexAttrib2fv"));
		VertexAttrib2sInstance = Marshal.GetDelegateForFunctionPointer<VertexAttrib2sDelegate>(loader("glVertexAttrib2s"));
		VertexAttrib2svInstance = Marshal.GetDelegateForFunctionPointer<VertexAttrib2svDelegate>(loader("glVertexAttrib2sv"));
		VertexAttrib3dInstance = Marshal.GetDelegateForFunctionPointer<VertexAttrib3dDelegate>(loader("glVertexAttrib3d"));
		VertexAttrib3dvInstance = Marshal.GetDelegateForFunctionPointer<VertexAttrib3dvDelegate>(loader("glVertexAttrib3dv"));
		VertexAttrib3fInstance = Marshal.GetDelegateForFunctionPointer<VertexAttrib3fDelegate>(loader("glVertexAttrib3f"));
		VertexAttrib3fvInstance = Marshal.GetDelegateForFunctionPointer<VertexAttrib3fvDelegate>(loader("glVertexAttrib3fv"));
		VertexAttrib3sInstance = Marshal.GetDelegateForFunctionPointer<VertexAttrib3sDelegate>(loader("glVertexAttrib3s"));
		VertexAttrib3svInstance = Marshal.GetDelegateForFunctionPointer<VertexAttrib3svDelegate>(loader("glVertexAttrib3sv"));
		VertexAttrib4NbvInstance = Marshal.GetDelegateForFunctionPointer<VertexAttrib4NbvDelegate>(loader("glVertexAttrib4Nbv"));
		VertexAttrib4NivInstance = Marshal.GetDelegateForFunctionPointer<VertexAttrib4NivDelegate>(loader("glVertexAttrib4Niv"));
		VertexAttrib4NsvInstance = Marshal.GetDelegateForFunctionPointer<VertexAttrib4NsvDelegate>(loader("glVertexAttrib4Nsv"));
		VertexAttrib4NubInstance = Marshal.GetDelegateForFunctionPointer<VertexAttrib4NubDelegate>(loader("glVertexAttrib4Nub"));
		VertexAttrib4NubvInstance = Marshal.GetDelegateForFunctionPointer<VertexAttrib4NubvDelegate>(loader("glVertexAttrib4Nubv"));
		VertexAttrib4NuivInstance = Marshal.GetDelegateForFunctionPointer<VertexAttrib4NuivDelegate>(loader("glVertexAttrib4Nuiv"));
		VertexAttrib4NusvInstance = Marshal.GetDelegateForFunctionPointer<VertexAttrib4NusvDelegate>(loader("glVertexAttrib4Nusv"));
		VertexAttrib4bvInstance = Marshal.GetDelegateForFunctionPointer<VertexAttrib4bvDelegate>(loader("glVertexAttrib4bv"));
		VertexAttrib4dInstance = Marshal.GetDelegateForFunctionPointer<VertexAttrib4dDelegate>(loader("glVertexAttrib4d"));
		VertexAttrib4dvInstance = Marshal.GetDelegateForFunctionPointer<VertexAttrib4dvDelegate>(loader("glVertexAttrib4dv"));
		VertexAttrib4fInstance = Marshal.GetDelegateForFunctionPointer<VertexAttrib4fDelegate>(loader("glVertexAttrib4f"));
		VertexAttrib4fvInstance = Marshal.GetDelegateForFunctionPointer<VertexAttrib4fvDelegate>(loader("glVertexAttrib4fv"));
		VertexAttrib4ivInstance = Marshal.GetDelegateForFunctionPointer<VertexAttrib4ivDelegate>(loader("glVertexAttrib4iv"));
		VertexAttrib4sInstance = Marshal.GetDelegateForFunctionPointer<VertexAttrib4sDelegate>(loader("glVertexAttrib4s"));
		VertexAttrib4svInstance = Marshal.GetDelegateForFunctionPointer<VertexAttrib4svDelegate>(loader("glVertexAttrib4sv"));
		VertexAttrib4ubvInstance = Marshal.GetDelegateForFunctionPointer<VertexAttrib4ubvDelegate>(loader("glVertexAttrib4ubv"));
		VertexAttrib4uivInstance = Marshal.GetDelegateForFunctionPointer<VertexAttrib4uivDelegate>(loader("glVertexAttrib4uiv"));
		VertexAttrib4usvInstance = Marshal.GetDelegateForFunctionPointer<VertexAttrib4usvDelegate>(loader("glVertexAttrib4usv"));
		VertexAttribPointerInstance = Marshal.GetDelegateForFunctionPointer<VertexAttribPointerDelegate>(loader("glVertexAttribPointer"));
		UniformMatrix2x3fvInstance = Marshal.GetDelegateForFunctionPointer<UniformMatrix2x3fvDelegate>(loader("glUniformMatrix2x3fv"));
		UniformMatrix3x2fvInstance = Marshal.GetDelegateForFunctionPointer<UniformMatrix3x2fvDelegate>(loader("glUniformMatrix3x2fv"));
		UniformMatrix2x4fvInstance = Marshal.GetDelegateForFunctionPointer<UniformMatrix2x4fvDelegate>(loader("glUniformMatrix2x4fv"));
		UniformMatrix4x2fvInstance = Marshal.GetDelegateForFunctionPointer<UniformMatrix4x2fvDelegate>(loader("glUniformMatrix4x2fv"));
		UniformMatrix3x4fvInstance = Marshal.GetDelegateForFunctionPointer<UniformMatrix3x4fvDelegate>(loader("glUniformMatrix3x4fv"));
		UniformMatrix4x3fvInstance = Marshal.GetDelegateForFunctionPointer<UniformMatrix4x3fvDelegate>(loader("glUniformMatrix4x3fv"));
		ColorMaskiInstance = Marshal.GetDelegateForFunctionPointer<ColorMaskiDelegate>(loader("glColorMaski"));
		GetBooleani_vInstance = Marshal.GetDelegateForFunctionPointer<GetBooleani_vDelegate>(loader("glGetBooleani_v"));
		GetIntegeri_vInstance = Marshal.GetDelegateForFunctionPointer<GetIntegeri_vDelegate>(loader("glGetIntegeri_v"));
		EnableiInstance = Marshal.GetDelegateForFunctionPointer<EnableiDelegate>(loader("glEnablei"));
		DisableiInstance = Marshal.GetDelegateForFunctionPointer<DisableiDelegate>(loader("glDisablei"));
		IsEnablediInstance = Marshal.GetDelegateForFunctionPointer<IsEnablediDelegate>(loader("glIsEnabledi"));
		BeginTransformFeedbackInstance = Marshal.GetDelegateForFunctionPointer<BeginTransformFeedbackDelegate>(loader("glBeginTransformFeedback"));
		EndTransformFeedbackInstance = Marshal.GetDelegateForFunctionPointer<EndTransformFeedbackDelegate>(loader("glEndTransformFeedback"));
		BindBufferRangeInstance = Marshal.GetDelegateForFunctionPointer<BindBufferRangeDelegate>(loader("glBindBufferRange"));
		BindBufferBaseInstance = Marshal.GetDelegateForFunctionPointer<BindBufferBaseDelegate>(loader("glBindBufferBase"));
		TransformFeedbackVaryingsInstance = Marshal.GetDelegateForFunctionPointer<TransformFeedbackVaryingsDelegate>(loader("glTransformFeedbackVaryings"));
		GetTransformFeedbackVaryingInstance = Marshal.GetDelegateForFunctionPointer<GetTransformFeedbackVaryingDelegate>(loader("glGetTransformFeedbackVarying"));
		ClampColorInstance = Marshal.GetDelegateForFunctionPointer<ClampColorDelegate>(loader("glClampColor"));
		BeginConditionalRenderInstance = Marshal.GetDelegateForFunctionPointer<BeginConditionalRenderDelegate>(loader("glBeginConditionalRender"));
		EndConditionalRenderInstance = Marshal.GetDelegateForFunctionPointer<EndConditionalRenderDelegate>(loader("glEndConditionalRender"));
		VertexAttribIPointerInstance = Marshal.GetDelegateForFunctionPointer<VertexAttribIPointerDelegate>(loader("glVertexAttribIPointer"));
		GetVertexAttribIivInstance = Marshal.GetDelegateForFunctionPointer<GetVertexAttribIivDelegate>(loader("glGetVertexAttribIiv"));
		GetVertexAttribIuivInstance = Marshal.GetDelegateForFunctionPointer<GetVertexAttribIuivDelegate>(loader("glGetVertexAttribIuiv"));
		VertexAttribI1iInstance = Marshal.GetDelegateForFunctionPointer<VertexAttribI1iDelegate>(loader("glVertexAttribI1i"));
		VertexAttribI2iInstance = Marshal.GetDelegateForFunctionPointer<VertexAttribI2iDelegate>(loader("glVertexAttribI2i"));
		VertexAttribI3iInstance = Marshal.GetDelegateForFunctionPointer<VertexAttribI3iDelegate>(loader("glVertexAttribI3i"));
		VertexAttribI4iInstance = Marshal.GetDelegateForFunctionPointer<VertexAttribI4iDelegate>(loader("glVertexAttribI4i"));
		VertexAttribI1uiInstance = Marshal.GetDelegateForFunctionPointer<VertexAttribI1uiDelegate>(loader("glVertexAttribI1ui"));
		VertexAttribI2uiInstance = Marshal.GetDelegateForFunctionPointer<VertexAttribI2uiDelegate>(loader("glVertexAttribI2ui"));
		VertexAttribI3uiInstance = Marshal.GetDelegateForFunctionPointer<VertexAttribI3uiDelegate>(loader("glVertexAttribI3ui"));
		VertexAttribI4uiInstance = Marshal.GetDelegateForFunctionPointer<VertexAttribI4uiDelegate>(loader("glVertexAttribI4ui"));
		VertexAttribI1ivInstance = Marshal.GetDelegateForFunctionPointer<VertexAttribI1ivDelegate>(loader("glVertexAttribI1iv"));
		VertexAttribI2ivInstance = Marshal.GetDelegateForFunctionPointer<VertexAttribI2ivDelegate>(loader("glVertexAttribI2iv"));
		VertexAttribI3ivInstance = Marshal.GetDelegateForFunctionPointer<VertexAttribI3ivDelegate>(loader("glVertexAttribI3iv"));
		VertexAttribI4ivInstance = Marshal.GetDelegateForFunctionPointer<VertexAttribI4ivDelegate>(loader("glVertexAttribI4iv"));
		VertexAttribI1uivInstance = Marshal.GetDelegateForFunctionPointer<VertexAttribI1uivDelegate>(loader("glVertexAttribI1uiv"));
		VertexAttribI2uivInstance = Marshal.GetDelegateForFunctionPointer<VertexAttribI2uivDelegate>(loader("glVertexAttribI2uiv"));
		VertexAttribI3uivInstance = Marshal.GetDelegateForFunctionPointer<VertexAttribI3uivDelegate>(loader("glVertexAttribI3uiv"));
		VertexAttribI4uivInstance = Marshal.GetDelegateForFunctionPointer<VertexAttribI4uivDelegate>(loader("glVertexAttribI4uiv"));
		VertexAttribI4bvInstance = Marshal.GetDelegateForFunctionPointer<VertexAttribI4bvDelegate>(loader("glVertexAttribI4bv"));
		VertexAttribI4svInstance = Marshal.GetDelegateForFunctionPointer<VertexAttribI4svDelegate>(loader("glVertexAttribI4sv"));
		VertexAttribI4ubvInstance = Marshal.GetDelegateForFunctionPointer<VertexAttribI4ubvDelegate>(loader("glVertexAttribI4ubv"));
		VertexAttribI4usvInstance = Marshal.GetDelegateForFunctionPointer<VertexAttribI4usvDelegate>(loader("glVertexAttribI4usv"));
		GetUniformuivInstance = Marshal.GetDelegateForFunctionPointer<GetUniformuivDelegate>(loader("glGetUniformuiv"));
		BindFragDataLocationInstance = Marshal.GetDelegateForFunctionPointer<BindFragDataLocationDelegate>(loader("glBindFragDataLocation"));
		GetFragDataLocationInstance = Marshal.GetDelegateForFunctionPointer<GetFragDataLocationDelegate>(loader("glGetFragDataLocation"));
		Uniform1uiInstance = Marshal.GetDelegateForFunctionPointer<Uniform1uiDelegate>(loader("glUniform1ui"));
		Uniform2uiInstance = Marshal.GetDelegateForFunctionPointer<Uniform2uiDelegate>(loader("glUniform2ui"));
		Uniform3uiInstance = Marshal.GetDelegateForFunctionPointer<Uniform3uiDelegate>(loader("glUniform3ui"));
		Uniform4uiInstance = Marshal.GetDelegateForFunctionPointer<Uniform4uiDelegate>(loader("glUniform4ui"));
		Uniform1uivInstance = Marshal.GetDelegateForFunctionPointer<Uniform1uivDelegate>(loader("glUniform1uiv"));
		Uniform2uivInstance = Marshal.GetDelegateForFunctionPointer<Uniform2uivDelegate>(loader("glUniform2uiv"));
		Uniform3uivInstance = Marshal.GetDelegateForFunctionPointer<Uniform3uivDelegate>(loader("glUniform3uiv"));
		Uniform4uivInstance = Marshal.GetDelegateForFunctionPointer<Uniform4uivDelegate>(loader("glUniform4uiv"));
		TexParameterIivInstance = Marshal.GetDelegateForFunctionPointer<TexParameterIivDelegate>(loader("glTexParameterIiv"));
		TexParameterIuivInstance = Marshal.GetDelegateForFunctionPointer<TexParameterIuivDelegate>(loader("glTexParameterIuiv"));
		GetTexParameterIivInstance = Marshal.GetDelegateForFunctionPointer<GetTexParameterIivDelegate>(loader("glGetTexParameterIiv"));
		GetTexParameterIuivInstance = Marshal.GetDelegateForFunctionPointer<GetTexParameterIuivDelegate>(loader("glGetTexParameterIuiv"));
		ClearBufferivInstance = Marshal.GetDelegateForFunctionPointer<ClearBufferivDelegate>(loader("glClearBufferiv"));
		ClearBufferuivInstance = Marshal.GetDelegateForFunctionPointer<ClearBufferuivDelegate>(loader("glClearBufferuiv"));
		ClearBufferfvInstance = Marshal.GetDelegateForFunctionPointer<ClearBufferfvDelegate>(loader("glClearBufferfv"));
		ClearBufferfiInstance = Marshal.GetDelegateForFunctionPointer<ClearBufferfiDelegate>(loader("glClearBufferfi"));
		GetStringiInstance = Marshal.GetDelegateForFunctionPointer<GetStringiDelegate>(loader("glGetStringi"));
		IsRenderbufferInstance = Marshal.GetDelegateForFunctionPointer<IsRenderbufferDelegate>(loader("glIsRenderbuffer"));
		BindRenderbufferInstance = Marshal.GetDelegateForFunctionPointer<BindRenderbufferDelegate>(loader("glBindRenderbuffer"));
		DeleteRenderbuffersInstance = Marshal.GetDelegateForFunctionPointer<DeleteRenderbuffersDelegate>(loader("glDeleteRenderbuffers"));
		GenRenderbuffersInstance = Marshal.GetDelegateForFunctionPointer<GenRenderbuffersDelegate>(loader("glGenRenderbuffers"));
		RenderbufferStorageInstance = Marshal.GetDelegateForFunctionPointer<RenderbufferStorageDelegate>(loader("glRenderbufferStorage"));
		GetRenderbufferParameterivInstance = Marshal.GetDelegateForFunctionPointer<GetRenderbufferParameterivDelegate>(loader("glGetRenderbufferParameteriv"));
		IsFramebufferInstance = Marshal.GetDelegateForFunctionPointer<IsFramebufferDelegate>(loader("glIsFramebuffer"));
		BindFramebufferInstance = Marshal.GetDelegateForFunctionPointer<BindFramebufferDelegate>(loader("glBindFramebuffer"));
		DeleteFramebuffersInstance = Marshal.GetDelegateForFunctionPointer<DeleteFramebuffersDelegate>(loader("glDeleteFramebuffers"));
		GenFramebuffersInstance = Marshal.GetDelegateForFunctionPointer<GenFramebuffersDelegate>(loader("glGenFramebuffers"));
		CheckFramebufferStatusInstance = Marshal.GetDelegateForFunctionPointer<CheckFramebufferStatusDelegate>(loader("glCheckFramebufferStatus"));
		FramebufferTexture1DInstance = Marshal.GetDelegateForFunctionPointer<FramebufferTexture1DDelegate>(loader("glFramebufferTexture1D"));
		FramebufferTexture2DInstance = Marshal.GetDelegateForFunctionPointer<FramebufferTexture2DDelegate>(loader("glFramebufferTexture2D"));
		FramebufferTexture3DInstance = Marshal.GetDelegateForFunctionPointer<FramebufferTexture3DDelegate>(loader("glFramebufferTexture3D"));
		FramebufferRenderbufferInstance = Marshal.GetDelegateForFunctionPointer<FramebufferRenderbufferDelegate>(loader("glFramebufferRenderbuffer"));
		GetFramebufferAttachmentParameterivInstance = Marshal.GetDelegateForFunctionPointer<GetFramebufferAttachmentParameterivDelegate>(loader("glGetFramebufferAttachmentParameteriv"));
		GenerateMipmapInstance = Marshal.GetDelegateForFunctionPointer<GenerateMipmapDelegate>(loader("glGenerateMipmap"));
		BlitFramebufferInstance = Marshal.GetDelegateForFunctionPointer<BlitFramebufferDelegate>(loader("glBlitFramebuffer"));
		RenderbufferStorageMultisampleInstance = Marshal.GetDelegateForFunctionPointer<RenderbufferStorageMultisampleDelegate>(loader("glRenderbufferStorageMultisample"));
		FramebufferTextureLayerInstance = Marshal.GetDelegateForFunctionPointer<FramebufferTextureLayerDelegate>(loader("glFramebufferTextureLayer"));
		MapBufferRangeInstance = Marshal.GetDelegateForFunctionPointer<MapBufferRangeDelegate>(loader("glMapBufferRange"));
		FlushMappedBufferRangeInstance = Marshal.GetDelegateForFunctionPointer<FlushMappedBufferRangeDelegate>(loader("glFlushMappedBufferRange"));
		BindVertexArrayInstance = Marshal.GetDelegateForFunctionPointer<BindVertexArrayDelegate>(loader("glBindVertexArray"));
		DeleteVertexArraysInstance = Marshal.GetDelegateForFunctionPointer<DeleteVertexArraysDelegate>(loader("glDeleteVertexArrays"));
		GenVertexArraysInstance = Marshal.GetDelegateForFunctionPointer<GenVertexArraysDelegate>(loader("glGenVertexArrays"));
		IsVertexArrayInstance = Marshal.GetDelegateForFunctionPointer<IsVertexArrayDelegate>(loader("glIsVertexArray"));
		DrawArraysInstancedInstance = Marshal.GetDelegateForFunctionPointer<DrawArraysInstancedDelegate>(loader("glDrawArraysInstanced"));
		DrawElementsInstancedInstance = Marshal.GetDelegateForFunctionPointer<DrawElementsInstancedDelegate>(loader("glDrawElementsInstanced"));
		TexBufferInstance = Marshal.GetDelegateForFunctionPointer<TexBufferDelegate>(loader("glTexBuffer"));
		PrimitiveRestartIndexInstance = Marshal.GetDelegateForFunctionPointer<PrimitiveRestartIndexDelegate>(loader("glPrimitiveRestartIndex"));
		CopyBufferSubDataInstance = Marshal.GetDelegateForFunctionPointer<CopyBufferSubDataDelegate>(loader("glCopyBufferSubData"));
		GetUniformIndicesInstance = Marshal.GetDelegateForFunctionPointer<GetUniformIndicesDelegate>(loader("glGetUniformIndices"));
		GetActiveUniformsivInstance = Marshal.GetDelegateForFunctionPointer<GetActiveUniformsivDelegate>(loader("glGetActiveUniformsiv"));
		GetActiveUniformNameInstance = Marshal.GetDelegateForFunctionPointer<GetActiveUniformNameDelegate>(loader("glGetActiveUniformName"));
		GetUniformBlockIndexInstance = Marshal.GetDelegateForFunctionPointer<GetUniformBlockIndexDelegate>(loader("glGetUniformBlockIndex"));
		GetActiveUniformBlockivInstance = Marshal.GetDelegateForFunctionPointer<GetActiveUniformBlockivDelegate>(loader("glGetActiveUniformBlockiv"));
		GetActiveUniformBlockNameInstance = Marshal.GetDelegateForFunctionPointer<GetActiveUniformBlockNameDelegate>(loader("glGetActiveUniformBlockName"));
		UniformBlockBindingInstance = Marshal.GetDelegateForFunctionPointer<UniformBlockBindingDelegate>(loader("glUniformBlockBinding"));
		DrawElementsBaseVertexInstance = Marshal.GetDelegateForFunctionPointer<DrawElementsBaseVertexDelegate>(loader("glDrawElementsBaseVertex"));
		DrawRangeElementsBaseVertexInstance = Marshal.GetDelegateForFunctionPointer<DrawRangeElementsBaseVertexDelegate>(loader("glDrawRangeElementsBaseVertex"));
		DrawElementsInstancedBaseVertexInstance = Marshal.GetDelegateForFunctionPointer<DrawElementsInstancedBaseVertexDelegate>(loader("glDrawElementsInstancedBaseVertex"));
		MultiDrawElementsBaseVertexInstance = Marshal.GetDelegateForFunctionPointer<MultiDrawElementsBaseVertexDelegate>(loader("glMultiDrawElementsBaseVertex"));
		ProvokingVertexInstance = Marshal.GetDelegateForFunctionPointer<ProvokingVertexDelegate>(loader("glProvokingVertex"));
		FenceSyncInstance = Marshal.GetDelegateForFunctionPointer<FenceSyncDelegate>(loader("glFenceSync"));
		IsSyncInstance = Marshal.GetDelegateForFunctionPointer<IsSyncDelegate>(loader("glIsSync"));
		DeleteSyncInstance = Marshal.GetDelegateForFunctionPointer<DeleteSyncDelegate>(loader("glDeleteSync"));
		ClientWaitSyncInstance = Marshal.GetDelegateForFunctionPointer<ClientWaitSyncDelegate>(loader("glClientWaitSync"));
		WaitSyncInstance = Marshal.GetDelegateForFunctionPointer<WaitSyncDelegate>(loader("glWaitSync"));
		GetInteger64vInstance = Marshal.GetDelegateForFunctionPointer<GetInteger64vDelegate>(loader("glGetInteger64v"));
		GetSyncivInstance = Marshal.GetDelegateForFunctionPointer<GetSyncivDelegate>(loader("glGetSynciv"));
		GetInteger64i_vInstance = Marshal.GetDelegateForFunctionPointer<GetInteger64i_vDelegate>(loader("glGetInteger64i_v"));
		GetBufferParameteri64vInstance = Marshal.GetDelegateForFunctionPointer<GetBufferParameteri64vDelegate>(loader("glGetBufferParameteri64v"));
		FramebufferTextureInstance = Marshal.GetDelegateForFunctionPointer<FramebufferTextureDelegate>(loader("glFramebufferTexture"));
		TexImage2DMultisampleInstance = Marshal.GetDelegateForFunctionPointer<TexImage2DMultisampleDelegate>(loader("glTexImage2DMultisample"));
		TexImage3DMultisampleInstance = Marshal.GetDelegateForFunctionPointer<TexImage3DMultisampleDelegate>(loader("glTexImage3DMultisample"));
		GetMultisamplefvInstance = Marshal.GetDelegateForFunctionPointer<GetMultisamplefvDelegate>(loader("glGetMultisamplefv"));
		SampleMaskiInstance = Marshal.GetDelegateForFunctionPointer<SampleMaskiDelegate>(loader("glSampleMaski"));
		BindFragDataLocationIndexedInstance = Marshal.GetDelegateForFunctionPointer<BindFragDataLocationIndexedDelegate>(loader("glBindFragDataLocationIndexed"));
		GetFragDataIndexInstance = Marshal.GetDelegateForFunctionPointer<GetFragDataIndexDelegate>(loader("glGetFragDataIndex"));
		GenSamplersInstance = Marshal.GetDelegateForFunctionPointer<GenSamplersDelegate>(loader("glGenSamplers"));
		DeleteSamplersInstance = Marshal.GetDelegateForFunctionPointer<DeleteSamplersDelegate>(loader("glDeleteSamplers"));
		IsSamplerInstance = Marshal.GetDelegateForFunctionPointer<IsSamplerDelegate>(loader("glIsSampler"));
		BindSamplerInstance = Marshal.GetDelegateForFunctionPointer<BindSamplerDelegate>(loader("glBindSampler"));
		SamplerParameteriInstance = Marshal.GetDelegateForFunctionPointer<SamplerParameteriDelegate>(loader("glSamplerParameteri"));
		SamplerParameterivInstance = Marshal.GetDelegateForFunctionPointer<SamplerParameterivDelegate>(loader("glSamplerParameteriv"));
		SamplerParameterfInstance = Marshal.GetDelegateForFunctionPointer<SamplerParameterfDelegate>(loader("glSamplerParameterf"));
		SamplerParameterfvInstance = Marshal.GetDelegateForFunctionPointer<SamplerParameterfvDelegate>(loader("glSamplerParameterfv"));
		SamplerParameterIivInstance = Marshal.GetDelegateForFunctionPointer<SamplerParameterIivDelegate>(loader("glSamplerParameterIiv"));
		SamplerParameterIuivInstance = Marshal.GetDelegateForFunctionPointer<SamplerParameterIuivDelegate>(loader("glSamplerParameterIuiv"));
		GetSamplerParameterivInstance = Marshal.GetDelegateForFunctionPointer<GetSamplerParameterivDelegate>(loader("glGetSamplerParameteriv"));
		GetSamplerParameterIivInstance = Marshal.GetDelegateForFunctionPointer<GetSamplerParameterIivDelegate>(loader("glGetSamplerParameterIiv"));
		GetSamplerParameterfvInstance = Marshal.GetDelegateForFunctionPointer<GetSamplerParameterfvDelegate>(loader("glGetSamplerParameterfv"));
		GetSamplerParameterIuivInstance = Marshal.GetDelegateForFunctionPointer<GetSamplerParameterIuivDelegate>(loader("glGetSamplerParameterIuiv"));
		QueryCounterInstance = Marshal.GetDelegateForFunctionPointer<QueryCounterDelegate>(loader("glQueryCounter"));
		GetQueryObjecti64vInstance = Marshal.GetDelegateForFunctionPointer<GetQueryObjecti64vDelegate>(loader("glGetQueryObjecti64v"));
		GetQueryObjectui64vInstance = Marshal.GetDelegateForFunctionPointer<GetQueryObjectui64vDelegate>(loader("glGetQueryObjectui64v"));
		VertexAttribDivisorInstance = Marshal.GetDelegateForFunctionPointer<VertexAttribDivisorDelegate>(loader("glVertexAttribDivisor"));
		VertexAttribP1uiInstance = Marshal.GetDelegateForFunctionPointer<VertexAttribP1uiDelegate>(loader("glVertexAttribP1ui"));
		VertexAttribP1uivInstance = Marshal.GetDelegateForFunctionPointer<VertexAttribP1uivDelegate>(loader("glVertexAttribP1uiv"));
		VertexAttribP2uiInstance = Marshal.GetDelegateForFunctionPointer<VertexAttribP2uiDelegate>(loader("glVertexAttribP2ui"));
		VertexAttribP2uivInstance = Marshal.GetDelegateForFunctionPointer<VertexAttribP2uivDelegate>(loader("glVertexAttribP2uiv"));
		VertexAttribP3uiInstance = Marshal.GetDelegateForFunctionPointer<VertexAttribP3uiDelegate>(loader("glVertexAttribP3ui"));
		VertexAttribP3uivInstance = Marshal.GetDelegateForFunctionPointer<VertexAttribP3uivDelegate>(loader("glVertexAttribP3uiv"));
		VertexAttribP4uiInstance = Marshal.GetDelegateForFunctionPointer<VertexAttribP4uiDelegate>(loader("glVertexAttribP4ui"));
		VertexAttribP4uivInstance = Marshal.GetDelegateForFunctionPointer<VertexAttribP4uivDelegate>(loader("glVertexAttribP4uiv"));
		MinSampleShadingInstance = Marshal.GetDelegateForFunctionPointer<MinSampleShadingDelegate>(loader("glMinSampleShading"));
		BlendEquationiInstance = Marshal.GetDelegateForFunctionPointer<BlendEquationiDelegate>(loader("glBlendEquationi"));
		BlendEquationSeparateiInstance = Marshal.GetDelegateForFunctionPointer<BlendEquationSeparateiDelegate>(loader("glBlendEquationSeparatei"));
		BlendFunciInstance = Marshal.GetDelegateForFunctionPointer<BlendFunciDelegate>(loader("glBlendFunci"));
		BlendFuncSeparateiInstance = Marshal.GetDelegateForFunctionPointer<BlendFuncSeparateiDelegate>(loader("glBlendFuncSeparatei"));
		DrawArraysIndirectInstance = Marshal.GetDelegateForFunctionPointer<DrawArraysIndirectDelegate>(loader("glDrawArraysIndirect"));
		DrawElementsIndirectInstance = Marshal.GetDelegateForFunctionPointer<DrawElementsIndirectDelegate>(loader("glDrawElementsIndirect"));
		Uniform1dInstance = Marshal.GetDelegateForFunctionPointer<Uniform1dDelegate>(loader("glUniform1d"));
		Uniform2dInstance = Marshal.GetDelegateForFunctionPointer<Uniform2dDelegate>(loader("glUniform2d"));
		Uniform3dInstance = Marshal.GetDelegateForFunctionPointer<Uniform3dDelegate>(loader("glUniform3d"));
		Uniform4dInstance = Marshal.GetDelegateForFunctionPointer<Uniform4dDelegate>(loader("glUniform4d"));
		Uniform1dvInstance = Marshal.GetDelegateForFunctionPointer<Uniform1dvDelegate>(loader("glUniform1dv"));
		Uniform2dvInstance = Marshal.GetDelegateForFunctionPointer<Uniform2dvDelegate>(loader("glUniform2dv"));
		Uniform3dvInstance = Marshal.GetDelegateForFunctionPointer<Uniform3dvDelegate>(loader("glUniform3dv"));
		Uniform4dvInstance = Marshal.GetDelegateForFunctionPointer<Uniform4dvDelegate>(loader("glUniform4dv"));
		UniformMatrix2dvInstance = Marshal.GetDelegateForFunctionPointer<UniformMatrix2dvDelegate>(loader("glUniformMatrix2dv"));
		UniformMatrix3dvInstance = Marshal.GetDelegateForFunctionPointer<UniformMatrix3dvDelegate>(loader("glUniformMatrix3dv"));
		UniformMatrix4dvInstance = Marshal.GetDelegateForFunctionPointer<UniformMatrix4dvDelegate>(loader("glUniformMatrix4dv"));
		UniformMatrix2x3dvInstance = Marshal.GetDelegateForFunctionPointer<UniformMatrix2x3dvDelegate>(loader("glUniformMatrix2x3dv"));
		UniformMatrix2x4dvInstance = Marshal.GetDelegateForFunctionPointer<UniformMatrix2x4dvDelegate>(loader("glUniformMatrix2x4dv"));
		UniformMatrix3x2dvInstance = Marshal.GetDelegateForFunctionPointer<UniformMatrix3x2dvDelegate>(loader("glUniformMatrix3x2dv"));
		UniformMatrix3x4dvInstance = Marshal.GetDelegateForFunctionPointer<UniformMatrix3x4dvDelegate>(loader("glUniformMatrix3x4dv"));
		UniformMatrix4x2dvInstance = Marshal.GetDelegateForFunctionPointer<UniformMatrix4x2dvDelegate>(loader("glUniformMatrix4x2dv"));
		UniformMatrix4x3dvInstance = Marshal.GetDelegateForFunctionPointer<UniformMatrix4x3dvDelegate>(loader("glUniformMatrix4x3dv"));
		GetUniformdvInstance = Marshal.GetDelegateForFunctionPointer<GetUniformdvDelegate>(loader("glGetUniformdv"));
		GetSubroutineUniformLocationInstance = Marshal.GetDelegateForFunctionPointer<GetSubroutineUniformLocationDelegate>(loader("glGetSubroutineUniformLocation"));
		GetSubroutineIndexInstance = Marshal.GetDelegateForFunctionPointer<GetSubroutineIndexDelegate>(loader("glGetSubroutineIndex"));
		GetActiveSubroutineUniformivInstance = Marshal.GetDelegateForFunctionPointer<GetActiveSubroutineUniformivDelegate>(loader("glGetActiveSubroutineUniformiv"));
		GetActiveSubroutineUniformNameInstance = Marshal.GetDelegateForFunctionPointer<GetActiveSubroutineUniformNameDelegate>(loader("glGetActiveSubroutineUniformName"));
		GetActiveSubroutineNameInstance = Marshal.GetDelegateForFunctionPointer<GetActiveSubroutineNameDelegate>(loader("glGetActiveSubroutineName"));
		UniformSubroutinesuivInstance = Marshal.GetDelegateForFunctionPointer<UniformSubroutinesuivDelegate>(loader("glUniformSubroutinesuiv"));
		GetUniformSubroutineuivInstance = Marshal.GetDelegateForFunctionPointer<GetUniformSubroutineuivDelegate>(loader("glGetUniformSubroutineuiv"));
		GetProgramStageivInstance = Marshal.GetDelegateForFunctionPointer<GetProgramStageivDelegate>(loader("glGetProgramStageiv"));
		PatchParameteriInstance = Marshal.GetDelegateForFunctionPointer<PatchParameteriDelegate>(loader("glPatchParameteri"));
		PatchParameterfvInstance = Marshal.GetDelegateForFunctionPointer<PatchParameterfvDelegate>(loader("glPatchParameterfv"));
		BindTransformFeedbackInstance = Marshal.GetDelegateForFunctionPointer<BindTransformFeedbackDelegate>(loader("glBindTransformFeedback"));
		DeleteTransformFeedbacksInstance = Marshal.GetDelegateForFunctionPointer<DeleteTransformFeedbacksDelegate>(loader("glDeleteTransformFeedbacks"));
		GenTransformFeedbacksInstance = Marshal.GetDelegateForFunctionPointer<GenTransformFeedbacksDelegate>(loader("glGenTransformFeedbacks"));
		IsTransformFeedbackInstance = Marshal.GetDelegateForFunctionPointer<IsTransformFeedbackDelegate>(loader("glIsTransformFeedback"));
		PauseTransformFeedbackInstance = Marshal.GetDelegateForFunctionPointer<PauseTransformFeedbackDelegate>(loader("glPauseTransformFeedback"));
		ResumeTransformFeedbackInstance = Marshal.GetDelegateForFunctionPointer<ResumeTransformFeedbackDelegate>(loader("glResumeTransformFeedback"));
		DrawTransformFeedbackInstance = Marshal.GetDelegateForFunctionPointer<DrawTransformFeedbackDelegate>(loader("glDrawTransformFeedback"));
		DrawTransformFeedbackStreamInstance = Marshal.GetDelegateForFunctionPointer<DrawTransformFeedbackStreamDelegate>(loader("glDrawTransformFeedbackStream"));
		BeginQueryIndexedInstance = Marshal.GetDelegateForFunctionPointer<BeginQueryIndexedDelegate>(loader("glBeginQueryIndexed"));
		EndQueryIndexedInstance = Marshal.GetDelegateForFunctionPointer<EndQueryIndexedDelegate>(loader("glEndQueryIndexed"));
		GetQueryIndexedivInstance = Marshal.GetDelegateForFunctionPointer<GetQueryIndexedivDelegate>(loader("glGetQueryIndexediv"));
		ReleaseShaderCompilerInstance = Marshal.GetDelegateForFunctionPointer<ReleaseShaderCompilerDelegate>(loader("glReleaseShaderCompiler"));
		ShaderBinaryInstance = Marshal.GetDelegateForFunctionPointer<ShaderBinaryDelegate>(loader("glShaderBinary"));
		GetShaderPrecisionFormatInstance = Marshal.GetDelegateForFunctionPointer<GetShaderPrecisionFormatDelegate>(loader("glGetShaderPrecisionFormat"));
		DepthRangefInstance = Marshal.GetDelegateForFunctionPointer<DepthRangefDelegate>(loader("glDepthRangef"));
		ClearDepthfInstance = Marshal.GetDelegateForFunctionPointer<ClearDepthfDelegate>(loader("glClearDepthf"));
		GetProgramBinaryInstance = Marshal.GetDelegateForFunctionPointer<GetProgramBinaryDelegate>(loader("glGetProgramBinary"));
		ProgramBinaryInstance = Marshal.GetDelegateForFunctionPointer<ProgramBinaryDelegate>(loader("glProgramBinary"));
		ProgramParameteriInstance = Marshal.GetDelegateForFunctionPointer<ProgramParameteriDelegate>(loader("glProgramParameteri"));
		UseProgramStagesInstance = Marshal.GetDelegateForFunctionPointer<UseProgramStagesDelegate>(loader("glUseProgramStages"));
		ActiveShaderProgramInstance = Marshal.GetDelegateForFunctionPointer<ActiveShaderProgramDelegate>(loader("glActiveShaderProgram"));
		CreateShaderProgramvInstance = Marshal.GetDelegateForFunctionPointer<CreateShaderProgramvDelegate>(loader("glCreateShaderProgramv"));
		BindProgramPipelineInstance = Marshal.GetDelegateForFunctionPointer<BindProgramPipelineDelegate>(loader("glBindProgramPipeline"));
		DeleteProgramPipelinesInstance = Marshal.GetDelegateForFunctionPointer<DeleteProgramPipelinesDelegate>(loader("glDeleteProgramPipelines"));
		GenProgramPipelinesInstance = Marshal.GetDelegateForFunctionPointer<GenProgramPipelinesDelegate>(loader("glGenProgramPipelines"));
		IsProgramPipelineInstance = Marshal.GetDelegateForFunctionPointer<IsProgramPipelineDelegate>(loader("glIsProgramPipeline"));
		GetProgramPipelineivInstance = Marshal.GetDelegateForFunctionPointer<GetProgramPipelineivDelegate>(loader("glGetProgramPipelineiv"));
		ProgramUniform1iInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniform1iDelegate>(loader("glProgramUniform1i"));
		ProgramUniform1ivInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniform1ivDelegate>(loader("glProgramUniform1iv"));
		ProgramUniform1fInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniform1fDelegate>(loader("glProgramUniform1f"));
		ProgramUniform1fvInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniform1fvDelegate>(loader("glProgramUniform1fv"));
		ProgramUniform1dInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniform1dDelegate>(loader("glProgramUniform1d"));
		ProgramUniform1dvInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniform1dvDelegate>(loader("glProgramUniform1dv"));
		ProgramUniform1uiInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniform1uiDelegate>(loader("glProgramUniform1ui"));
		ProgramUniform1uivInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniform1uivDelegate>(loader("glProgramUniform1uiv"));
		ProgramUniform2iInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniform2iDelegate>(loader("glProgramUniform2i"));
		ProgramUniform2ivInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniform2ivDelegate>(loader("glProgramUniform2iv"));
		ProgramUniform2fInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniform2fDelegate>(loader("glProgramUniform2f"));
		ProgramUniform2fvInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniform2fvDelegate>(loader("glProgramUniform2fv"));
		ProgramUniform2dInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniform2dDelegate>(loader("glProgramUniform2d"));
		ProgramUniform2dvInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniform2dvDelegate>(loader("glProgramUniform2dv"));
		ProgramUniform2uiInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniform2uiDelegate>(loader("glProgramUniform2ui"));
		ProgramUniform2uivInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniform2uivDelegate>(loader("glProgramUniform2uiv"));
		ProgramUniform3iInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniform3iDelegate>(loader("glProgramUniform3i"));
		ProgramUniform3ivInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniform3ivDelegate>(loader("glProgramUniform3iv"));
		ProgramUniform3fInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniform3fDelegate>(loader("glProgramUniform3f"));
		ProgramUniform3fvInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniform3fvDelegate>(loader("glProgramUniform3fv"));
		ProgramUniform3dInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniform3dDelegate>(loader("glProgramUniform3d"));
		ProgramUniform3dvInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniform3dvDelegate>(loader("glProgramUniform3dv"));
		ProgramUniform3uiInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniform3uiDelegate>(loader("glProgramUniform3ui"));
		ProgramUniform3uivInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniform3uivDelegate>(loader("glProgramUniform3uiv"));
		ProgramUniform4iInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniform4iDelegate>(loader("glProgramUniform4i"));
		ProgramUniform4ivInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniform4ivDelegate>(loader("glProgramUniform4iv"));
		ProgramUniform4fInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniform4fDelegate>(loader("glProgramUniform4f"));
		ProgramUniform4fvInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniform4fvDelegate>(loader("glProgramUniform4fv"));
		ProgramUniform4dInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniform4dDelegate>(loader("glProgramUniform4d"));
		ProgramUniform4dvInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniform4dvDelegate>(loader("glProgramUniform4dv"));
		ProgramUniform4uiInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniform4uiDelegate>(loader("glProgramUniform4ui"));
		ProgramUniform4uivInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniform4uivDelegate>(loader("glProgramUniform4uiv"));
		ProgramUniformMatrix2fvInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniformMatrix2fvDelegate>(loader("glProgramUniformMatrix2fv"));
		ProgramUniformMatrix3fvInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniformMatrix3fvDelegate>(loader("glProgramUniformMatrix3fv"));
		ProgramUniformMatrix4fvInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniformMatrix4fvDelegate>(loader("glProgramUniformMatrix4fv"));
		ProgramUniformMatrix2dvInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniformMatrix2dvDelegate>(loader("glProgramUniformMatrix2dv"));
		ProgramUniformMatrix3dvInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniformMatrix3dvDelegate>(loader("glProgramUniformMatrix3dv"));
		ProgramUniformMatrix4dvInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniformMatrix4dvDelegate>(loader("glProgramUniformMatrix4dv"));
		ProgramUniformMatrix2x3fvInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniformMatrix2x3fvDelegate>(loader("glProgramUniformMatrix2x3fv"));
		ProgramUniformMatrix3x2fvInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniformMatrix3x2fvDelegate>(loader("glProgramUniformMatrix3x2fv"));
		ProgramUniformMatrix2x4fvInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniformMatrix2x4fvDelegate>(loader("glProgramUniformMatrix2x4fv"));
		ProgramUniformMatrix4x2fvInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniformMatrix4x2fvDelegate>(loader("glProgramUniformMatrix4x2fv"));
		ProgramUniformMatrix3x4fvInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniformMatrix3x4fvDelegate>(loader("glProgramUniformMatrix3x4fv"));
		ProgramUniformMatrix4x3fvInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniformMatrix4x3fvDelegate>(loader("glProgramUniformMatrix4x3fv"));
		ProgramUniformMatrix2x3dvInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniformMatrix2x3dvDelegate>(loader("glProgramUniformMatrix2x3dv"));
		ProgramUniformMatrix3x2dvInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniformMatrix3x2dvDelegate>(loader("glProgramUniformMatrix3x2dv"));
		ProgramUniformMatrix2x4dvInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniformMatrix2x4dvDelegate>(loader("glProgramUniformMatrix2x4dv"));
		ProgramUniformMatrix4x2dvInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniformMatrix4x2dvDelegate>(loader("glProgramUniformMatrix4x2dv"));
		ProgramUniformMatrix3x4dvInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniformMatrix3x4dvDelegate>(loader("glProgramUniformMatrix3x4dv"));
		ProgramUniformMatrix4x3dvInstance = Marshal.GetDelegateForFunctionPointer<ProgramUniformMatrix4x3dvDelegate>(loader("glProgramUniformMatrix4x3dv"));
		ValidateProgramPipelineInstance = Marshal.GetDelegateForFunctionPointer<ValidateProgramPipelineDelegate>(loader("glValidateProgramPipeline"));
		GetProgramPipelineInfoLogInstance = Marshal.GetDelegateForFunctionPointer<GetProgramPipelineInfoLogDelegate>(loader("glGetProgramPipelineInfoLog"));
		VertexAttribL1dInstance = Marshal.GetDelegateForFunctionPointer<VertexAttribL1dDelegate>(loader("glVertexAttribL1d"));
		VertexAttribL2dInstance = Marshal.GetDelegateForFunctionPointer<VertexAttribL2dDelegate>(loader("glVertexAttribL2d"));
		VertexAttribL3dInstance = Marshal.GetDelegateForFunctionPointer<VertexAttribL3dDelegate>(loader("glVertexAttribL3d"));
		VertexAttribL4dInstance = Marshal.GetDelegateForFunctionPointer<VertexAttribL4dDelegate>(loader("glVertexAttribL4d"));
		VertexAttribL1dvInstance = Marshal.GetDelegateForFunctionPointer<VertexAttribL1dvDelegate>(loader("glVertexAttribL1dv"));
		VertexAttribL2dvInstance = Marshal.GetDelegateForFunctionPointer<VertexAttribL2dvDelegate>(loader("glVertexAttribL2dv"));
		VertexAttribL3dvInstance = Marshal.GetDelegateForFunctionPointer<VertexAttribL3dvDelegate>(loader("glVertexAttribL3dv"));
		VertexAttribL4dvInstance = Marshal.GetDelegateForFunctionPointer<VertexAttribL4dvDelegate>(loader("glVertexAttribL4dv"));
		VertexAttribLPointerInstance = Marshal.GetDelegateForFunctionPointer<VertexAttribLPointerDelegate>(loader("glVertexAttribLPointer"));
		GetVertexAttribLdvInstance = Marshal.GetDelegateForFunctionPointer<GetVertexAttribLdvDelegate>(loader("glGetVertexAttribLdv"));
		ViewportArrayvInstance = Marshal.GetDelegateForFunctionPointer<ViewportArrayvDelegate>(loader("glViewportArrayv"));
		ViewportIndexedfInstance = Marshal.GetDelegateForFunctionPointer<ViewportIndexedfDelegate>(loader("glViewportIndexedf"));
		ViewportIndexedfvInstance = Marshal.GetDelegateForFunctionPointer<ViewportIndexedfvDelegate>(loader("glViewportIndexedfv"));
		ScissorArrayvInstance = Marshal.GetDelegateForFunctionPointer<ScissorArrayvDelegate>(loader("glScissorArrayv"));
		ScissorIndexedInstance = Marshal.GetDelegateForFunctionPointer<ScissorIndexedDelegate>(loader("glScissorIndexed"));
		ScissorIndexedvInstance = Marshal.GetDelegateForFunctionPointer<ScissorIndexedvDelegate>(loader("glScissorIndexedv"));
		DepthRangeArrayvInstance = Marshal.GetDelegateForFunctionPointer<DepthRangeArrayvDelegate>(loader("glDepthRangeArrayv"));
		DepthRangeIndexedInstance = Marshal.GetDelegateForFunctionPointer<DepthRangeIndexedDelegate>(loader("glDepthRangeIndexed"));
		GetFloati_vInstance = Marshal.GetDelegateForFunctionPointer<GetFloati_vDelegate>(loader("glGetFloati_v"));
		GetDoublei_vInstance = Marshal.GetDelegateForFunctionPointer<GetDoublei_vDelegate>(loader("glGetDoublei_v"));
		DrawArraysInstancedBaseInstanceInstance = Marshal.GetDelegateForFunctionPointer<DrawArraysInstancedBaseInstanceDelegate>(loader("glDrawArraysInstancedBaseInstance"));
		DrawElementsInstancedBaseInstanceInstance = Marshal.GetDelegateForFunctionPointer<DrawElementsInstancedBaseInstanceDelegate>(loader("glDrawElementsInstancedBaseInstance"));
		DrawElementsInstancedBaseVertexBaseInstanceInstance = Marshal.GetDelegateForFunctionPointer<DrawElementsInstancedBaseVertexBaseInstanceDelegate>(loader("glDrawElementsInstancedBaseVertexBaseInstance"));
		GetInternalformativInstance = Marshal.GetDelegateForFunctionPointer<GetInternalformativDelegate>(loader("glGetInternalformativ"));
		GetActiveAtomicCounterBufferivInstance = Marshal.GetDelegateForFunctionPointer<GetActiveAtomicCounterBufferivDelegate>(loader("glGetActiveAtomicCounterBufferiv"));
		BindImageTextureInstance = Marshal.GetDelegateForFunctionPointer<BindImageTextureDelegate>(loader("glBindImageTexture"));
		MemoryBarrierInstance = Marshal.GetDelegateForFunctionPointer<MemoryBarrierDelegate>(loader("glMemoryBarrier"));
		TexStorage1DInstance = Marshal.GetDelegateForFunctionPointer<TexStorage1DDelegate>(loader("glTexStorage1D"));
		TexStorage2DInstance = Marshal.GetDelegateForFunctionPointer<TexStorage2DDelegate>(loader("glTexStorage2D"));
		TexStorage3DInstance = Marshal.GetDelegateForFunctionPointer<TexStorage3DDelegate>(loader("glTexStorage3D"));
		DrawTransformFeedbackInstancedInstance = Marshal.GetDelegateForFunctionPointer<DrawTransformFeedbackInstancedDelegate>(loader("glDrawTransformFeedbackInstanced"));
		DrawTransformFeedbackStreamInstancedInstance = Marshal.GetDelegateForFunctionPointer<DrawTransformFeedbackStreamInstancedDelegate>(loader("glDrawTransformFeedbackStreamInstanced"));
		ClearBufferDataInstance = Marshal.GetDelegateForFunctionPointer<ClearBufferDataDelegate>(loader("glClearBufferData"));
		ClearBufferSubDataInstance = Marshal.GetDelegateForFunctionPointer<ClearBufferSubDataDelegate>(loader("glClearBufferSubData"));
		DispatchComputeInstance = Marshal.GetDelegateForFunctionPointer<DispatchComputeDelegate>(loader("glDispatchCompute"));
		DispatchComputeIndirectInstance = Marshal.GetDelegateForFunctionPointer<DispatchComputeIndirectDelegate>(loader("glDispatchComputeIndirect"));
		CopyImageSubDataInstance = Marshal.GetDelegateForFunctionPointer<CopyImageSubDataDelegate>(loader("glCopyImageSubData"));
		FramebufferParameteriInstance = Marshal.GetDelegateForFunctionPointer<FramebufferParameteriDelegate>(loader("glFramebufferParameteri"));
		GetFramebufferParameterivInstance = Marshal.GetDelegateForFunctionPointer<GetFramebufferParameterivDelegate>(loader("glGetFramebufferParameteriv"));
		GetInternalformati64vInstance = Marshal.GetDelegateForFunctionPointer<GetInternalformati64vDelegate>(loader("glGetInternalformati64v"));
		InvalidateTexSubImageInstance = Marshal.GetDelegateForFunctionPointer<InvalidateTexSubImageDelegate>(loader("glInvalidateTexSubImage"));
		InvalidateTexImageInstance = Marshal.GetDelegateForFunctionPointer<InvalidateTexImageDelegate>(loader("glInvalidateTexImage"));
		InvalidateBufferSubDataInstance = Marshal.GetDelegateForFunctionPointer<InvalidateBufferSubDataDelegate>(loader("glInvalidateBufferSubData"));
		InvalidateBufferDataInstance = Marshal.GetDelegateForFunctionPointer<InvalidateBufferDataDelegate>(loader("glInvalidateBufferData"));
		InvalidateFramebufferInstance = Marshal.GetDelegateForFunctionPointer<InvalidateFramebufferDelegate>(loader("glInvalidateFramebuffer"));
		InvalidateSubFramebufferInstance = Marshal.GetDelegateForFunctionPointer<InvalidateSubFramebufferDelegate>(loader("glInvalidateSubFramebuffer"));
		MultiDrawArraysIndirectInstance = Marshal.GetDelegateForFunctionPointer<MultiDrawArraysIndirectDelegate>(loader("glMultiDrawArraysIndirect"));
		MultiDrawElementsIndirectInstance = Marshal.GetDelegateForFunctionPointer<MultiDrawElementsIndirectDelegate>(loader("glMultiDrawElementsIndirect"));
		GetProgramInterfaceivInstance = Marshal.GetDelegateForFunctionPointer<GetProgramInterfaceivDelegate>(loader("glGetProgramInterfaceiv"));
		GetProgramResourceIndexInstance = Marshal.GetDelegateForFunctionPointer<GetProgramResourceIndexDelegate>(loader("glGetProgramResourceIndex"));
		GetProgramResourceNameInstance = Marshal.GetDelegateForFunctionPointer<GetProgramResourceNameDelegate>(loader("glGetProgramResourceName"));
		GetProgramResourceivInstance = Marshal.GetDelegateForFunctionPointer<GetProgramResourceivDelegate>(loader("glGetProgramResourceiv"));
		GetProgramResourceLocationInstance = Marshal.GetDelegateForFunctionPointer<GetProgramResourceLocationDelegate>(loader("glGetProgramResourceLocation"));
		GetProgramResourceLocationIndexInstance = Marshal.GetDelegateForFunctionPointer<GetProgramResourceLocationIndexDelegate>(loader("glGetProgramResourceLocationIndex"));
		ShaderStorageBlockBindingInstance = Marshal.GetDelegateForFunctionPointer<ShaderStorageBlockBindingDelegate>(loader("glShaderStorageBlockBinding"));
		TexBufferRangeInstance = Marshal.GetDelegateForFunctionPointer<TexBufferRangeDelegate>(loader("glTexBufferRange"));
		TexStorage2DMultisampleInstance = Marshal.GetDelegateForFunctionPointer<TexStorage2DMultisampleDelegate>(loader("glTexStorage2DMultisample"));
		TexStorage3DMultisampleInstance = Marshal.GetDelegateForFunctionPointer<TexStorage3DMultisampleDelegate>(loader("glTexStorage3DMultisample"));
		TextureViewInstance = Marshal.GetDelegateForFunctionPointer<TextureViewDelegate>(loader("glTextureView"));
		BindVertexBufferInstance = Marshal.GetDelegateForFunctionPointer<BindVertexBufferDelegate>(loader("glBindVertexBuffer"));
		VertexAttribFormatInstance = Marshal.GetDelegateForFunctionPointer<VertexAttribFormatDelegate>(loader("glVertexAttribFormat"));
		VertexAttribIFormatInstance = Marshal.GetDelegateForFunctionPointer<VertexAttribIFormatDelegate>(loader("glVertexAttribIFormat"));
		VertexAttribLFormatInstance = Marshal.GetDelegateForFunctionPointer<VertexAttribLFormatDelegate>(loader("glVertexAttribLFormat"));
		VertexAttribBindingInstance = Marshal.GetDelegateForFunctionPointer<VertexAttribBindingDelegate>(loader("glVertexAttribBinding"));
		VertexBindingDivisorInstance = Marshal.GetDelegateForFunctionPointer<VertexBindingDivisorDelegate>(loader("glVertexBindingDivisor"));
		GetPointervInstance = Marshal.GetDelegateForFunctionPointer<GetPointervDelegate>(loader("glGetPointerv"));
		BufferStorageInstance = Marshal.GetDelegateForFunctionPointer<BufferStorageDelegate>(loader("glBufferStorage"));
		ClearTexImageInstance = Marshal.GetDelegateForFunctionPointer<ClearTexImageDelegate>(loader("glClearTexImage"));
		ClearTexSubImageInstance = Marshal.GetDelegateForFunctionPointer<ClearTexSubImageDelegate>(loader("glClearTexSubImage"));
		BindBuffersBaseInstance = Marshal.GetDelegateForFunctionPointer<BindBuffersBaseDelegate>(loader("glBindBuffersBase"));
		BindBuffersRangeInstance = Marshal.GetDelegateForFunctionPointer<BindBuffersRangeDelegate>(loader("glBindBuffersRange"));
		BindTexturesInstance = Marshal.GetDelegateForFunctionPointer<BindTexturesDelegate>(loader("glBindTextures"));
		BindSamplersInstance = Marshal.GetDelegateForFunctionPointer<BindSamplersDelegate>(loader("glBindSamplers"));
		BindImageTexturesInstance = Marshal.GetDelegateForFunctionPointer<BindImageTexturesDelegate>(loader("glBindImageTextures"));
		BindVertexBuffersInstance = Marshal.GetDelegateForFunctionPointer<BindVertexBuffersDelegate>(loader("glBindVertexBuffers"));
		ClipControlInstance = Marshal.GetDelegateForFunctionPointer<ClipControlDelegate>(loader("glClipControl"));
		CreateTransformFeedbacksInstance = Marshal.GetDelegateForFunctionPointer<CreateTransformFeedbacksDelegate>(loader("glCreateTransformFeedbacks"));
		TransformFeedbackBufferBaseInstance = Marshal.GetDelegateForFunctionPointer<TransformFeedbackBufferBaseDelegate>(loader("glTransformFeedbackBufferBase"));
		TransformFeedbackBufferRangeInstance = Marshal.GetDelegateForFunctionPointer<TransformFeedbackBufferRangeDelegate>(loader("glTransformFeedbackBufferRange"));
		GetTransformFeedbackivInstance = Marshal.GetDelegateForFunctionPointer<GetTransformFeedbackivDelegate>(loader("glGetTransformFeedbackiv"));
		GetTransformFeedbacki_vInstance = Marshal.GetDelegateForFunctionPointer<GetTransformFeedbacki_vDelegate>(loader("glGetTransformFeedbacki_v"));
		GetTransformFeedbacki64_vInstance = Marshal.GetDelegateForFunctionPointer<GetTransformFeedbacki64_vDelegate>(loader("glGetTransformFeedbacki64_v"));
		CreateBuffersInstance = Marshal.GetDelegateForFunctionPointer<CreateBuffersDelegate>(loader("glCreateBuffers"));
		NamedBufferStorageInstance = Marshal.GetDelegateForFunctionPointer<NamedBufferStorageDelegate>(loader("glNamedBufferStorage"));
		NamedBufferDataInstance = Marshal.GetDelegateForFunctionPointer<NamedBufferDataDelegate>(loader("glNamedBufferData"));
		NamedBufferSubDataInstance = Marshal.GetDelegateForFunctionPointer<NamedBufferSubDataDelegate>(loader("glNamedBufferSubData"));
		CopyNamedBufferSubDataInstance = Marshal.GetDelegateForFunctionPointer<CopyNamedBufferSubDataDelegate>(loader("glCopyNamedBufferSubData"));
		ClearNamedBufferDataInstance = Marshal.GetDelegateForFunctionPointer<ClearNamedBufferDataDelegate>(loader("glClearNamedBufferData"));
		ClearNamedBufferSubDataInstance = Marshal.GetDelegateForFunctionPointer<ClearNamedBufferSubDataDelegate>(loader("glClearNamedBufferSubData"));
		MapNamedBufferInstance = Marshal.GetDelegateForFunctionPointer<MapNamedBufferDelegate>(loader("glMapNamedBuffer"));
		MapNamedBufferRangeInstance = Marshal.GetDelegateForFunctionPointer<MapNamedBufferRangeDelegate>(loader("glMapNamedBufferRange"));
		UnmapNamedBufferInstance = Marshal.GetDelegateForFunctionPointer<UnmapNamedBufferDelegate>(loader("glUnmapNamedBuffer"));
		FlushMappedNamedBufferRangeInstance = Marshal.GetDelegateForFunctionPointer<FlushMappedNamedBufferRangeDelegate>(loader("glFlushMappedNamedBufferRange"));
		GetNamedBufferParameterivInstance = Marshal.GetDelegateForFunctionPointer<GetNamedBufferParameterivDelegate>(loader("glGetNamedBufferParameteriv"));
		GetNamedBufferParameteri64vInstance = Marshal.GetDelegateForFunctionPointer<GetNamedBufferParameteri64vDelegate>(loader("glGetNamedBufferParameteri64v"));
		GetNamedBufferPointervInstance = Marshal.GetDelegateForFunctionPointer<GetNamedBufferPointervDelegate>(loader("glGetNamedBufferPointerv"));
		GetNamedBufferSubDataInstance = Marshal.GetDelegateForFunctionPointer<GetNamedBufferSubDataDelegate>(loader("glGetNamedBufferSubData"));
		CreateFramebuffersInstance = Marshal.GetDelegateForFunctionPointer<CreateFramebuffersDelegate>(loader("glCreateFramebuffers"));
		NamedFramebufferRenderbufferInstance = Marshal.GetDelegateForFunctionPointer<NamedFramebufferRenderbufferDelegate>(loader("glNamedFramebufferRenderbuffer"));
		NamedFramebufferParameteriInstance = Marshal.GetDelegateForFunctionPointer<NamedFramebufferParameteriDelegate>(loader("glNamedFramebufferParameteri"));
		NamedFramebufferTextureInstance = Marshal.GetDelegateForFunctionPointer<NamedFramebufferTextureDelegate>(loader("glNamedFramebufferTexture"));
		NamedFramebufferTextureLayerInstance = Marshal.GetDelegateForFunctionPointer<NamedFramebufferTextureLayerDelegate>(loader("glNamedFramebufferTextureLayer"));
		NamedFramebufferDrawBufferInstance = Marshal.GetDelegateForFunctionPointer<NamedFramebufferDrawBufferDelegate>(loader("glNamedFramebufferDrawBuffer"));
		NamedFramebufferDrawBuffersInstance = Marshal.GetDelegateForFunctionPointer<NamedFramebufferDrawBuffersDelegate>(loader("glNamedFramebufferDrawBuffers"));
		NamedFramebufferReadBufferInstance = Marshal.GetDelegateForFunctionPointer<NamedFramebufferReadBufferDelegate>(loader("glNamedFramebufferReadBuffer"));
		InvalidateNamedFramebufferDataInstance = Marshal.GetDelegateForFunctionPointer<InvalidateNamedFramebufferDataDelegate>(loader("glInvalidateNamedFramebufferData"));
		InvalidateNamedFramebufferSubDataInstance = Marshal.GetDelegateForFunctionPointer<InvalidateNamedFramebufferSubDataDelegate>(loader("glInvalidateNamedFramebufferSubData"));
		ClearNamedFramebufferivInstance = Marshal.GetDelegateForFunctionPointer<ClearNamedFramebufferivDelegate>(loader("glClearNamedFramebufferiv"));
		ClearNamedFramebufferuivInstance = Marshal.GetDelegateForFunctionPointer<ClearNamedFramebufferuivDelegate>(loader("glClearNamedFramebufferuiv"));
		ClearNamedFramebufferfvInstance = Marshal.GetDelegateForFunctionPointer<ClearNamedFramebufferfvDelegate>(loader("glClearNamedFramebufferfv"));
		ClearNamedFramebufferfiInstance = Marshal.GetDelegateForFunctionPointer<ClearNamedFramebufferfiDelegate>(loader("glClearNamedFramebufferfi"));
		BlitNamedFramebufferInstance = Marshal.GetDelegateForFunctionPointer<BlitNamedFramebufferDelegate>(loader("glBlitNamedFramebuffer"));
		CheckNamedFramebufferStatusInstance = Marshal.GetDelegateForFunctionPointer<CheckNamedFramebufferStatusDelegate>(loader("glCheckNamedFramebufferStatus"));
		GetNamedFramebufferParameterivInstance = Marshal.GetDelegateForFunctionPointer<GetNamedFramebufferParameterivDelegate>(loader("glGetNamedFramebufferParameteriv"));
		GetNamedFramebufferAttachmentParameterivInstance = Marshal.GetDelegateForFunctionPointer<GetNamedFramebufferAttachmentParameterivDelegate>(loader("glGetNamedFramebufferAttachmentParameteriv"));
		CreateRenderbuffersInstance = Marshal.GetDelegateForFunctionPointer<CreateRenderbuffersDelegate>(loader("glCreateRenderbuffers"));
		NamedRenderbufferStorageInstance = Marshal.GetDelegateForFunctionPointer<NamedRenderbufferStorageDelegate>(loader("glNamedRenderbufferStorage"));
		NamedRenderbufferStorageMultisampleInstance = Marshal.GetDelegateForFunctionPointer<NamedRenderbufferStorageMultisampleDelegate>(loader("glNamedRenderbufferStorageMultisample"));
		GetNamedRenderbufferParameterivInstance = Marshal.GetDelegateForFunctionPointer<GetNamedRenderbufferParameterivDelegate>(loader("glGetNamedRenderbufferParameteriv"));
		CreateTexturesInstance = Marshal.GetDelegateForFunctionPointer<CreateTexturesDelegate>(loader("glCreateTextures"));
		TextureBufferInstance = Marshal.GetDelegateForFunctionPointer<TextureBufferDelegate>(loader("glTextureBuffer"));
		TextureBufferRangeInstance = Marshal.GetDelegateForFunctionPointer<TextureBufferRangeDelegate>(loader("glTextureBufferRange"));
		TextureStorage1DInstance = Marshal.GetDelegateForFunctionPointer<TextureStorage1DDelegate>(loader("glTextureStorage1D"));
		TextureStorage2DInstance = Marshal.GetDelegateForFunctionPointer<TextureStorage2DDelegate>(loader("glTextureStorage2D"));
		TextureStorage3DInstance = Marshal.GetDelegateForFunctionPointer<TextureStorage3DDelegate>(loader("glTextureStorage3D"));
		TextureStorage2DMultisampleInstance = Marshal.GetDelegateForFunctionPointer<TextureStorage2DMultisampleDelegate>(loader("glTextureStorage2DMultisample"));
		TextureStorage3DMultisampleInstance = Marshal.GetDelegateForFunctionPointer<TextureStorage3DMultisampleDelegate>(loader("glTextureStorage3DMultisample"));
		TextureSubImage1DInstance = Marshal.GetDelegateForFunctionPointer<TextureSubImage1DDelegate>(loader("glTextureSubImage1D"));
		TextureSubImage2DInstance = Marshal.GetDelegateForFunctionPointer<TextureSubImage2DDelegate>(loader("glTextureSubImage2D"));
		TextureSubImage3DInstance = Marshal.GetDelegateForFunctionPointer<TextureSubImage3DDelegate>(loader("glTextureSubImage3D"));
		CompressedTextureSubImage1DInstance = Marshal.GetDelegateForFunctionPointer<CompressedTextureSubImage1DDelegate>(loader("glCompressedTextureSubImage1D"));
		CompressedTextureSubImage2DInstance = Marshal.GetDelegateForFunctionPointer<CompressedTextureSubImage2DDelegate>(loader("glCompressedTextureSubImage2D"));
		CompressedTextureSubImage3DInstance = Marshal.GetDelegateForFunctionPointer<CompressedTextureSubImage3DDelegate>(loader("glCompressedTextureSubImage3D"));
		CopyTextureSubImage1DInstance = Marshal.GetDelegateForFunctionPointer<CopyTextureSubImage1DDelegate>(loader("glCopyTextureSubImage1D"));
		CopyTextureSubImage2DInstance = Marshal.GetDelegateForFunctionPointer<CopyTextureSubImage2DDelegate>(loader("glCopyTextureSubImage2D"));
		CopyTextureSubImage3DInstance = Marshal.GetDelegateForFunctionPointer<CopyTextureSubImage3DDelegate>(loader("glCopyTextureSubImage3D"));
		TextureParameterfInstance = Marshal.GetDelegateForFunctionPointer<TextureParameterfDelegate>(loader("glTextureParameterf"));
		TextureParameterfvInstance = Marshal.GetDelegateForFunctionPointer<TextureParameterfvDelegate>(loader("glTextureParameterfv"));
		TextureParameteriInstance = Marshal.GetDelegateForFunctionPointer<TextureParameteriDelegate>(loader("glTextureParameteri"));
		TextureParameterIivInstance = Marshal.GetDelegateForFunctionPointer<TextureParameterIivDelegate>(loader("glTextureParameterIiv"));
		TextureParameterIuivInstance = Marshal.GetDelegateForFunctionPointer<TextureParameterIuivDelegate>(loader("glTextureParameterIuiv"));
		TextureParameterivInstance = Marshal.GetDelegateForFunctionPointer<TextureParameterivDelegate>(loader("glTextureParameteriv"));
		GenerateTextureMipmapInstance = Marshal.GetDelegateForFunctionPointer<GenerateTextureMipmapDelegate>(loader("glGenerateTextureMipmap"));
		BindTextureUnitInstance = Marshal.GetDelegateForFunctionPointer<BindTextureUnitDelegate>(loader("glBindTextureUnit"));
		GetTextureImageInstance = Marshal.GetDelegateForFunctionPointer<GetTextureImageDelegate>(loader("glGetTextureImage"));
		GetCompressedTextureImageInstance = Marshal.GetDelegateForFunctionPointer<GetCompressedTextureImageDelegate>(loader("glGetCompressedTextureImage"));
		GetTextureLevelParameterfvInstance = Marshal.GetDelegateForFunctionPointer<GetTextureLevelParameterfvDelegate>(loader("glGetTextureLevelParameterfv"));
		GetTextureLevelParameterivInstance = Marshal.GetDelegateForFunctionPointer<GetTextureLevelParameterivDelegate>(loader("glGetTextureLevelParameteriv"));
		GetTextureParameterfvInstance = Marshal.GetDelegateForFunctionPointer<GetTextureParameterfvDelegate>(loader("glGetTextureParameterfv"));
		GetTextureParameterIivInstance = Marshal.GetDelegateForFunctionPointer<GetTextureParameterIivDelegate>(loader("glGetTextureParameterIiv"));
		GetTextureParameterIuivInstance = Marshal.GetDelegateForFunctionPointer<GetTextureParameterIuivDelegate>(loader("glGetTextureParameterIuiv"));
		GetTextureParameterivInstance = Marshal.GetDelegateForFunctionPointer<GetTextureParameterivDelegate>(loader("glGetTextureParameteriv"));
		CreateVertexArraysInstance = Marshal.GetDelegateForFunctionPointer<CreateVertexArraysDelegate>(loader("glCreateVertexArrays"));
		DisableVertexArrayAttribInstance = Marshal.GetDelegateForFunctionPointer<DisableVertexArrayAttribDelegate>(loader("glDisableVertexArrayAttrib"));
		EnableVertexArrayAttribInstance = Marshal.GetDelegateForFunctionPointer<EnableVertexArrayAttribDelegate>(loader("glEnableVertexArrayAttrib"));
		VertexArrayElementBufferInstance = Marshal.GetDelegateForFunctionPointer<VertexArrayElementBufferDelegate>(loader("glVertexArrayElementBuffer"));
		VertexArrayVertexBufferInstance = Marshal.GetDelegateForFunctionPointer<VertexArrayVertexBufferDelegate>(loader("glVertexArrayVertexBuffer"));
		VertexArrayVertexBuffersInstance = Marshal.GetDelegateForFunctionPointer<VertexArrayVertexBuffersDelegate>(loader("glVertexArrayVertexBuffers"));
		VertexArrayAttribBindingInstance = Marshal.GetDelegateForFunctionPointer<VertexArrayAttribBindingDelegate>(loader("glVertexArrayAttribBinding"));
		VertexArrayAttribFormatInstance = Marshal.GetDelegateForFunctionPointer<VertexArrayAttribFormatDelegate>(loader("glVertexArrayAttribFormat"));
		VertexArrayAttribIFormatInstance = Marshal.GetDelegateForFunctionPointer<VertexArrayAttribIFormatDelegate>(loader("glVertexArrayAttribIFormat"));
		VertexArrayAttribLFormatInstance = Marshal.GetDelegateForFunctionPointer<VertexArrayAttribLFormatDelegate>(loader("glVertexArrayAttribLFormat"));
		VertexArrayBindingDivisorInstance = Marshal.GetDelegateForFunctionPointer<VertexArrayBindingDivisorDelegate>(loader("glVertexArrayBindingDivisor"));
		GetVertexArrayivInstance = Marshal.GetDelegateForFunctionPointer<GetVertexArrayivDelegate>(loader("glGetVertexArrayiv"));
		GetVertexArrayIndexedivInstance = Marshal.GetDelegateForFunctionPointer<GetVertexArrayIndexedivDelegate>(loader("glGetVertexArrayIndexediv"));
		GetVertexArrayIndexed64ivInstance = Marshal.GetDelegateForFunctionPointer<GetVertexArrayIndexed64ivDelegate>(loader("glGetVertexArrayIndexed64iv"));
		CreateSamplersInstance = Marshal.GetDelegateForFunctionPointer<CreateSamplersDelegate>(loader("glCreateSamplers"));
		CreateProgramPipelinesInstance = Marshal.GetDelegateForFunctionPointer<CreateProgramPipelinesDelegate>(loader("glCreateProgramPipelines"));
		CreateQueriesInstance = Marshal.GetDelegateForFunctionPointer<CreateQueriesDelegate>(loader("glCreateQueries"));
		GetQueryBufferObjecti64vInstance = Marshal.GetDelegateForFunctionPointer<GetQueryBufferObjecti64vDelegate>(loader("glGetQueryBufferObjecti64v"));
		GetQueryBufferObjectivInstance = Marshal.GetDelegateForFunctionPointer<GetQueryBufferObjectivDelegate>(loader("glGetQueryBufferObjectiv"));
		GetQueryBufferObjectui64vInstance = Marshal.GetDelegateForFunctionPointer<GetQueryBufferObjectui64vDelegate>(loader("glGetQueryBufferObjectui64v"));
		GetQueryBufferObjectuivInstance = Marshal.GetDelegateForFunctionPointer<GetQueryBufferObjectuivDelegate>(loader("glGetQueryBufferObjectuiv"));
		MemoryBarrierByRegionInstance = Marshal.GetDelegateForFunctionPointer<MemoryBarrierByRegionDelegate>(loader("glMemoryBarrierByRegion"));
		GetTextureSubImageInstance = Marshal.GetDelegateForFunctionPointer<GetTextureSubImageDelegate>(loader("glGetTextureSubImage"));
		GetCompressedTextureSubImageInstance = Marshal.GetDelegateForFunctionPointer<GetCompressedTextureSubImageDelegate>(loader("glGetCompressedTextureSubImage"));
		GetGraphicsResetStatusInstance = Marshal.GetDelegateForFunctionPointer<GetGraphicsResetStatusDelegate>(loader("glGetGraphicsResetStatus"));
		GetnCompressedTexImageInstance = Marshal.GetDelegateForFunctionPointer<GetnCompressedTexImageDelegate>(loader("glGetnCompressedTexImage"));
		GetnTexImageInstance = Marshal.GetDelegateForFunctionPointer<GetnTexImageDelegate>(loader("glGetnTexImage"));
		GetnUniformdvInstance = Marshal.GetDelegateForFunctionPointer<GetnUniformdvDelegate>(loader("glGetnUniformdv"));
		GetnUniformfvInstance = Marshal.GetDelegateForFunctionPointer<GetnUniformfvDelegate>(loader("glGetnUniformfv"));
		GetnUniformivInstance = Marshal.GetDelegateForFunctionPointer<GetnUniformivDelegate>(loader("glGetnUniformiv"));
		GetnUniformuivInstance = Marshal.GetDelegateForFunctionPointer<GetnUniformuivDelegate>(loader("glGetnUniformuiv"));
		ReadnPixelsInstance = Marshal.GetDelegateForFunctionPointer<ReadnPixelsDelegate>(loader("glReadnPixels"));
		TextureBarrierInstance = Marshal.GetDelegateForFunctionPointer<TextureBarrierDelegate>(loader("glTextureBarrier"));
	}
	#region DelegateTypes
	private delegate void DebugMessageControlDelegate(DebugSource source, DebugType type, DebugSeverity severity, int count, in uint ids, [MarshalAs(UnmanagedType.I1)] bool enabled);
	private delegate void DebugMessageInsertDelegate(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, IntPtr buf);
	private delegate void DebugMessageCallbackDelegate(PrivateDebugProc callback, IntPtr userParam);
	private delegate uint GetDebugMessageLogDelegate(uint count, int bufSize, out uint sources, out uint types, out uint ids, out uint severities, out int lengths, out sbyte messageLog);
	private delegate void PushDebugGroupDelegate(DebugSource source, uint id, int length, in sbyte message);
	private delegate void PopDebugGroupDelegate();
	private delegate void ObjectLabelDelegate(ObjectIdentifier identifier, uint name, int length, in sbyte label);
	private delegate void GetObjectLabelDelegate(ObjectIdentifier identifier, uint name, int bufSize, out int length, out sbyte label);
	private delegate void ObjectPtrLabelDelegate(in byte ptr, int length, in sbyte label);
	private delegate void GetObjectPtrLabelDelegate(in byte ptr, int bufSize, out int length, out sbyte label);
	private delegate void DebugMessageControlKHRDelegate(DebugSource source, DebugType type, DebugSeverity severity, int count, in uint ids, [MarshalAs(UnmanagedType.I1)] bool enabled);
	private delegate void DebugMessageInsertKHRDelegate(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, in sbyte buf);
	private delegate void DebugMessageCallbackKHRDelegate(PrivateDebugProcKHR callback, in byte userParam);
	private delegate uint GetDebugMessageLogKHRDelegate(uint count, int bufSize, out uint sources, out uint types, out uint ids, out uint severities, out int lengths, out sbyte messageLog);
	private delegate void PushDebugGroupKHRDelegate(DebugSource source, uint id, int length, in sbyte message);
	private delegate void PopDebugGroupKHRDelegate();
	private delegate void ObjectLabelKHRDelegate(ObjectIdentifier identifier, uint name, int length, in sbyte label);
	private delegate void GetObjectLabelKHRDelegate(uint identifier, uint name, int bufSize, out int length, out sbyte label);
	private delegate void ObjectPtrLabelKHRDelegate(in byte ptr, int length, in sbyte label);
	private delegate void GetObjectPtrLabelKHRDelegate(in byte ptr, int bufSize, out int length, out sbyte label);
	private delegate void GetPointervKHRDelegate(uint pname, out IntPtr @params);
	private delegate void CullFaceDelegate(TriangleFace mode);
	private delegate void FrontFaceDelegate(FrontFaceDirection mode);
	private delegate void HintDelegate(HintTarget target, HintMode mode);
	private delegate void LineWidthDelegate(float width);
	private delegate void PointSizeDelegate(float size);
	private delegate void PolygonModeDelegate(TriangleFace face, PolygonMode mode);
	private delegate void ScissorDelegate(int x, int y, int width, int height);
	private delegate void TexParameterfDelegate(TextureTarget target, TextureParameterName pname, float param);
	private delegate void TexParameterfvDelegate(TextureTarget target, TextureParameterName pname, in float @params);
	private delegate void TexParameteriDelegate(TextureTarget target, TextureParameterName pname, int param);
	private delegate void TexParameterivDelegate(TextureTarget target, TextureParameterName pname, in int @params);
	private delegate void TexImage1DDelegate(TextureTarget target, int level, InternalFormat internalformat, int width, int border, PixelFormat format, PixelType type, in byte pixels);
	private delegate void TexImage2DDelegate(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, PixelFormat format, PixelType type, in byte pixels);
	private delegate void DrawBufferDelegate(DrawBufferMode buf);
	private delegate void ClearDelegate(ClearBufferMask mask);
	private delegate void ClearColorDelegate(float red, float green, float blue, float alpha);
	private delegate void ClearStencilDelegate(int s);
	private delegate void ClearDepthDelegate(double depth);
	private delegate void StencilMaskDelegate(uint mask);
	private delegate void ColorMaskDelegate([MarshalAs(UnmanagedType.I1)] bool red, [MarshalAs(UnmanagedType.I1)] bool green, [MarshalAs(UnmanagedType.I1)] bool blue, [MarshalAs(UnmanagedType.I1)] bool alpha);
	private delegate void DepthMaskDelegate([MarshalAs(UnmanagedType.I1)] bool flag);
	private delegate void DisableDelegate(EnableCap cap);
	private delegate void EnableDelegate(EnableCap cap);
	private delegate void FinishDelegate();
	private delegate void FlushDelegate();
	private delegate void BlendFuncDelegate(BlendingFactor sfactor, BlendingFactor dfactor);
	private delegate void LogicOpDelegate(LogicOp opcode);
	private delegate void StencilFuncDelegate(StencilFunction func, int @ref, uint mask);
	private delegate void StencilOpDelegate(StencilOp fail, StencilOp zfail, StencilOp zpass);
	private delegate void DepthFuncDelegate(DepthFunction func);
	private delegate void PixelStorefDelegate(PixelStoreParameter pname, float param);
	private delegate void PixelStoreiDelegate(PixelStoreParameter pname, int param);
	private delegate void ReadBufferDelegate(ReadBufferMode src);
	private delegate void ReadPixelsDelegate(int x, int y, int width, int height, PixelFormat format, PixelType type, out byte pixels);
	private delegate void GetBooleanvDelegate(GetPName pname, out byte data);
	private delegate void GetDoublevDelegate(GetPName pname, out double data);
	private delegate ErrorCode GetErrorDelegate();
	private delegate void GetFloatvDelegate(GetPName pname, out float data);
	private delegate void GetIntegervDelegate(GetPName pname, out int data);
	private delegate IntPtr GetStringDelegate(StringName name);
	private delegate void GetTexImageDelegate(TextureTarget target, int level, PixelFormat format, PixelType type, out byte pixels);
	private delegate void GetTexParameterfvDelegate(TextureTarget target, GetTextureParameter pname, out float @params);
	private delegate void GetTexParameterivDelegate(TextureTarget target, GetTextureParameter pname, out int @params);
	private delegate void GetTexLevelParameterfvDelegate(TextureTarget target, int level, GetTextureParameter pname, out float @params);
	private delegate void GetTexLevelParameterivDelegate(TextureTarget target, int level, GetTextureParameter pname, out int @params);
	[return: MarshalAs(UnmanagedType.I1)]
	private delegate bool IsEnabledDelegate(EnableCap cap);
	private delegate void DepthRangeDelegate(double n, double f);
	private delegate void ViewportDelegate(int x, int y, int width, int height);
	private delegate void DrawArraysDelegate(PrimitiveType mode, int first, int count);
	private delegate void DrawElementsDelegate(PrimitiveType mode, int count, DrawElementsType type, nint indices);
	private delegate void PolygonOffsetDelegate(float factor, float units);
	private delegate void CopyTexImage1DDelegate(TextureTarget target, int level, InternalFormat internalformat, int x, int y, int width, int border);
	private delegate void CopyTexImage2DDelegate(TextureTarget target, int level, InternalFormat internalformat, int x, int y, int width, int height, int border);
	private delegate void CopyTexSubImage1DDelegate(TextureTarget target, int level, int xoffset, int x, int y, int width);
	private delegate void CopyTexSubImage2DDelegate(TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height);
	private delegate void TexSubImage1DDelegate(TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, in byte pixels);
	private delegate void TexSubImage2DDelegate(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, in byte pixels);
	private delegate void BindTextureDelegate(TextureTarget target, uint texture);
	private delegate void DeleteTexturesDelegate(int n, in uint textures);
	private delegate void GenTexturesDelegate(int n, out uint textures);
	[return: MarshalAs(UnmanagedType.I1)]
	private delegate bool IsTextureDelegate(uint texture);
	private delegate void DrawRangeElementsDelegate(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, in byte indices);
	private delegate void TexImage3DDelegate(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, in byte pixels);
	private delegate void TexSubImage3DDelegate(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, in byte pixels);
	private delegate void CopyTexSubImage3DDelegate(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
	private delegate void ActiveTextureDelegate(TextureUnit texture);
	private delegate void SampleCoverageDelegate(float value, [MarshalAs(UnmanagedType.I1)] bool invert);
	private delegate void CompressedTexImage3DDelegate(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, int imageSize, in byte data);
	private delegate void CompressedTexImage2DDelegate(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, int imageSize, in byte data);
	private delegate void CompressedTexImage1DDelegate(TextureTarget target, int level, InternalFormat internalformat, int width, int border, int imageSize, in byte data);
	private delegate void CompressedTexSubImage3DDelegate(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, InternalFormat format, int imageSize, in byte data);
	private delegate void CompressedTexSubImage2DDelegate(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, InternalFormat format, int imageSize, in byte data);
	private delegate void CompressedTexSubImage1DDelegate(TextureTarget target, int level, int xoffset, int width, InternalFormat format, int imageSize, in byte data);
	private delegate void GetCompressedTexImageDelegate(TextureTarget target, int level, out byte img);
	private delegate void BlendFuncSeparateDelegate(BlendingFactor sfactorRGB, BlendingFactor dfactorRGB, BlendingFactor sfactorAlpha, BlendingFactor dfactorAlpha);
	private delegate void MultiDrawArraysDelegate(PrimitiveType mode, in int first, in int count, int drawcount);
	private delegate void MultiDrawElementsDelegate(PrimitiveType mode, in int count, DrawElementsType type, in IntPtr indices, int drawcount);
	private delegate void PointParameterfDelegate(PointParameterNameARB pname, float param);
	private delegate void PointParameterfvDelegate(PointParameterNameARB pname, in float @params);
	private delegate void PointParameteriDelegate(PointParameterNameARB pname, int param);
	private delegate void PointParameterivDelegate(PointParameterNameARB pname, in int @params);
	private delegate void BlendColorDelegate(float red, float green, float blue, float alpha);
	private delegate void BlendEquationDelegate(BlendEquationModeEXT mode);
	private delegate void GenQueriesDelegate(int n, out uint ids);
	private delegate void DeleteQueriesDelegate(int n, in uint ids);
	[return: MarshalAs(UnmanagedType.I1)]
	private delegate bool IsQueryDelegate(uint id);
	private delegate void BeginQueryDelegate(QueryTarget target, uint id);
	private delegate void EndQueryDelegate(QueryTarget target);
	private delegate void GetQueryivDelegate(QueryTarget target, QueryParameterName pname, out int @params);
	private delegate void GetQueryObjectivDelegate(uint id, QueryObjectParameterName pname, out int @params);
	private delegate void GetQueryObjectuivDelegate(uint id, QueryObjectParameterName pname, out uint @params);
	private delegate void BindBufferDelegate(BufferTarget target, uint buffer);
	private delegate void DeleteBuffersDelegate(int n, in uint buffers);
	private delegate void GenBuffersDelegate(int n, out uint buffers);
	[return: MarshalAs(UnmanagedType.I1)]
	private delegate bool IsBufferDelegate(uint buffer);
	private delegate void BufferDataDelegate(BufferTarget target, nint size, in byte data, BufferUsage usage);
	private delegate void BufferSubDataDelegate(BufferTarget target, IntPtr offset, nint size, in byte data);
	private delegate void GetBufferSubDataDelegate(BufferTarget target, IntPtr offset, nint size, out byte data);
	private delegate IntPtr MapBufferDelegate(BufferTarget target, BufferAccessARB access);
	[return: MarshalAs(UnmanagedType.I1)]
	private delegate bool UnmapBufferDelegate(BufferTarget target);
	private delegate void GetBufferParameterivDelegate(BufferTarget target, BufferPNameARB pname, out int @params);
	private delegate void GetBufferPointervDelegate(BufferTarget target, BufferPointerNameARB pname, out IntPtr @params);
	private delegate void BlendEquationSeparateDelegate(BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha);
	private delegate void DrawBuffersDelegate(int n, in uint bufs);
	private delegate void StencilOpSeparateDelegate(TriangleFace face, StencilOp sfail, StencilOp dpfail, StencilOp dppass);
	private delegate void StencilFuncSeparateDelegate(TriangleFace face, StencilFunction func, int @ref, uint mask);
	private delegate void StencilMaskSeparateDelegate(TriangleFace face, uint mask);
	private delegate void AttachShaderDelegate(uint program, uint shader);
	private delegate void BindAttribLocationDelegate(uint program, uint index, in sbyte name);
	private delegate void CompileShaderDelegate(uint shader);
	private delegate uint CreateProgramDelegate();
	private delegate uint CreateShaderDelegate(ShaderType type);
	private delegate void DeleteProgramDelegate(uint program);
	private delegate void DeleteShaderDelegate(uint shader);
	private delegate void DetachShaderDelegate(uint program, uint shader);
	private delegate void DisableVertexAttribArrayDelegate(uint index);
	private delegate void EnableVertexAttribArrayDelegate(uint index);
	private delegate void GetActiveAttribDelegate(uint program, uint index, int bufSize, out int length, out int size, out uint type, out sbyte name);
	private delegate void GetActiveUniformDelegate(uint program, uint index, int bufSize, out int length, out int size, out uint type, out sbyte name);
	private delegate void GetAttachedShadersDelegate(uint program, int maxCount, out int count, out uint shaders);
	private delegate int GetAttribLocationDelegate(uint program, in sbyte name);
	private delegate void GetProgramivDelegate(uint program, ProgramPropertyARB pname, out int @params);
	private delegate void GetProgramInfoLogDelegate(uint program, int bufSize, out int length, out sbyte infoLog);
	private delegate void GetShaderivDelegate(uint shader, ShaderParameterName pname, out int @params);
	private delegate void GetShaderInfoLogDelegate(uint shader, int bufSize, out int length, nint infoLog);
	private delegate void GetShaderSourceDelegate(uint shader, int bufSize, out int length, out sbyte source);
	private delegate int GetUniformLocationDelegate(uint program, in sbyte name);
	private delegate void GetUniformfvDelegate(uint program, int location, out float @params);
	private delegate void GetUniformivDelegate(uint program, int location, out int @params);
	private delegate void GetVertexAttribdvDelegate(uint index, VertexAttribPropertyARB pname, out double @params);
	private delegate void GetVertexAttribfvDelegate(uint index, VertexAttribPropertyARB pname, out float @params);
	private delegate void GetVertexAttribivDelegate(uint index, VertexAttribPropertyARB pname, out int @params);
	private delegate void GetVertexAttribPointervDelegate(uint index, VertexAttribPointerPropertyARB pname, out IntPtr pointer);
	[return: MarshalAs(UnmanagedType.I1)]
	private delegate bool IsProgramDelegate(uint program);
	[return: MarshalAs(UnmanagedType.I1)]
	private delegate bool IsShaderDelegate(uint shader);
	private delegate void LinkProgramDelegate(uint program);
	private delegate void ShaderSourceDelegate(uint shader, int count, in IntPtr @string, in int length);
	private delegate void UseProgramDelegate(uint program);
	private delegate void Uniform1fDelegate(int location, float v0);
	private delegate void Uniform2fDelegate(int location, float v0, float v1);
	private delegate void Uniform3fDelegate(int location, float v0, float v1, float v2);
	private delegate void Uniform4fDelegate(int location, float v0, float v1, float v2, float v3);
	private delegate void Uniform1iDelegate(int location, int v0);
	private delegate void Uniform2iDelegate(int location, int v0, int v1);
	private delegate void Uniform3iDelegate(int location, int v0, int v1, int v2);
	private delegate void Uniform4iDelegate(int location, int v0, int v1, int v2, int v3);
	private delegate void Uniform1fvDelegate(int location, int count, in float value);
	private delegate void Uniform2fvDelegate(int location, int count, in float value);
	private delegate void Uniform3fvDelegate(int location, int count, in float value);
	private delegate void Uniform4fvDelegate(int location, int count, in float value);
	private delegate void Uniform1ivDelegate(int location, int count, in int value);
	private delegate void Uniform2ivDelegate(int location, int count, in int value);
	private delegate void Uniform3ivDelegate(int location, int count, in int value);
	private delegate void Uniform4ivDelegate(int location, int count, in int value);
	private delegate void UniformMatrix2fvDelegate(int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, in float value);
	private delegate void UniformMatrix3fvDelegate(int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, in float value);
	private delegate void UniformMatrix4fvDelegate(int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, in float value);
	private delegate void ValidateProgramDelegate(uint program);
	private delegate void VertexAttrib1dDelegate(uint index, double x);
	private delegate void VertexAttrib1dvDelegate(uint index, in double v);
	private delegate void VertexAttrib1fDelegate(uint index, float x);
	private delegate void VertexAttrib1fvDelegate(uint index, in float v);
	private delegate void VertexAttrib1sDelegate(uint index, short x);
	private delegate void VertexAttrib1svDelegate(uint index, in short v);
	private delegate void VertexAttrib2dDelegate(uint index, double x, double y);
	private delegate void VertexAttrib2dvDelegate(uint index, in double v);
	private delegate void VertexAttrib2fDelegate(uint index, float x, float y);
	private delegate void VertexAttrib2fvDelegate(uint index, in float v);
	private delegate void VertexAttrib2sDelegate(uint index, short x, short y);
	private delegate void VertexAttrib2svDelegate(uint index, in short v);
	private delegate void VertexAttrib3dDelegate(uint index, double x, double y, double z);
	private delegate void VertexAttrib3dvDelegate(uint index, in double v);
	private delegate void VertexAttrib3fDelegate(uint index, float x, float y, float z);
	private delegate void VertexAttrib3fvDelegate(uint index, in float v);
	private delegate void VertexAttrib3sDelegate(uint index, short x, short y, short z);
	private delegate void VertexAttrib3svDelegate(uint index, in short v);
	private delegate void VertexAttrib4NbvDelegate(uint index, in sbyte v);
	private delegate void VertexAttrib4NivDelegate(uint index, in int v);
	private delegate void VertexAttrib4NsvDelegate(uint index, in short v);
	private delegate void VertexAttrib4NubDelegate(uint index, byte x, byte y, byte z, byte w);
	private delegate void VertexAttrib4NubvDelegate(uint index, in byte v);
	private delegate void VertexAttrib4NuivDelegate(uint index, in uint v);
	private delegate void VertexAttrib4NusvDelegate(uint index, in ushort v);
	private delegate void VertexAttrib4bvDelegate(uint index, in sbyte v);
	private delegate void VertexAttrib4dDelegate(uint index, double x, double y, double z, double w);
	private delegate void VertexAttrib4dvDelegate(uint index, in double v);
	private delegate void VertexAttrib4fDelegate(uint index, float x, float y, float z, float w);
	private delegate void VertexAttrib4fvDelegate(uint index, in float v);
	private delegate void VertexAttrib4ivDelegate(uint index, in int v);
	private delegate void VertexAttrib4sDelegate(uint index, short x, short y, short z, short w);
	private delegate void VertexAttrib4svDelegate(uint index, in short v);
	private delegate void VertexAttrib4ubvDelegate(uint index, in byte v);
	private delegate void VertexAttrib4uivDelegate(uint index, in uint v);
	private delegate void VertexAttrib4usvDelegate(uint index, in ushort v);
	private delegate void VertexAttribPointerDelegate(uint index, int size, VertexAttribPointerType type, [MarshalAs(UnmanagedType.I1)] bool normalized, int stride, nint pointer);
	private delegate void UniformMatrix2x3fvDelegate(int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, in float value);
	private delegate void UniformMatrix3x2fvDelegate(int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, in float value);
	private delegate void UniformMatrix2x4fvDelegate(int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, in float value);
	private delegate void UniformMatrix4x2fvDelegate(int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, in float value);
	private delegate void UniformMatrix3x4fvDelegate(int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, in float value);
	private delegate void UniformMatrix4x3fvDelegate(int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, in float value);
	private delegate void ColorMaskiDelegate(uint index, [MarshalAs(UnmanagedType.I1)] bool r, [MarshalAs(UnmanagedType.I1)] bool g, [MarshalAs(UnmanagedType.I1)] bool b, [MarshalAs(UnmanagedType.I1)] bool a);
	private delegate void GetBooleani_vDelegate(BufferTarget target, uint index, out byte data);
	private delegate void GetIntegeri_vDelegate(GetPName target, uint index, out int data);
	private delegate void EnableiDelegate(EnableCap target, uint index);
	private delegate void DisableiDelegate(EnableCap target, uint index);
	[return: MarshalAs(UnmanagedType.I1)]
	private delegate bool IsEnablediDelegate(EnableCap target, uint index);
	private delegate void BeginTransformFeedbackDelegate(PrimitiveType primitiveMode);
	private delegate void EndTransformFeedbackDelegate();
	private delegate void BindBufferRangeDelegate(BufferTarget target, uint index, uint buffer, IntPtr offset, nint size);
	private delegate void BindBufferBaseDelegate(BufferTarget target, uint index, uint buffer);
	private delegate void TransformFeedbackVaryingsDelegate(uint program, int count, in IntPtr varyings, TransformFeedbackBufferMode bufferMode);
	private delegate void GetTransformFeedbackVaryingDelegate(uint program, uint index, int bufSize, out int length, out int size, out uint type, out sbyte name);
	private delegate void ClampColorDelegate(ClampColorTargetARB target, ClampColorModeARB clamp);
	private delegate void BeginConditionalRenderDelegate(uint id, ConditionalRenderMode mode);
	private delegate void EndConditionalRenderDelegate();
	private delegate void VertexAttribIPointerDelegate(uint index, int size, VertexAttribIType type, int stride, in byte pointer);
	private delegate void GetVertexAttribIivDelegate(uint index, VertexAttribEnum pname, out int @params);
	private delegate void GetVertexAttribIuivDelegate(uint index, VertexAttribEnum pname, out uint @params);
	private delegate void VertexAttribI1iDelegate(uint index, int x);
	private delegate void VertexAttribI2iDelegate(uint index, int x, int y);
	private delegate void VertexAttribI3iDelegate(uint index, int x, int y, int z);
	private delegate void VertexAttribI4iDelegate(uint index, int x, int y, int z, int w);
	private delegate void VertexAttribI1uiDelegate(uint index, uint x);
	private delegate void VertexAttribI2uiDelegate(uint index, uint x, uint y);
	private delegate void VertexAttribI3uiDelegate(uint index, uint x, uint y, uint z);
	private delegate void VertexAttribI4uiDelegate(uint index, uint x, uint y, uint z, uint w);
	private delegate void VertexAttribI1ivDelegate(uint index, in int v);
	private delegate void VertexAttribI2ivDelegate(uint index, in int v);
	private delegate void VertexAttribI3ivDelegate(uint index, in int v);
	private delegate void VertexAttribI4ivDelegate(uint index, in int v);
	private delegate void VertexAttribI1uivDelegate(uint index, in uint v);
	private delegate void VertexAttribI2uivDelegate(uint index, in uint v);
	private delegate void VertexAttribI3uivDelegate(uint index, in uint v);
	private delegate void VertexAttribI4uivDelegate(uint index, in uint v);
	private delegate void VertexAttribI4bvDelegate(uint index, in sbyte v);
	private delegate void VertexAttribI4svDelegate(uint index, in short v);
	private delegate void VertexAttribI4ubvDelegate(uint index, in byte v);
	private delegate void VertexAttribI4usvDelegate(uint index, in ushort v);
	private delegate void GetUniformuivDelegate(uint program, int location, out uint @params);
	private delegate void BindFragDataLocationDelegate(uint program, uint color, in sbyte name);
	private delegate int GetFragDataLocationDelegate(uint program, in sbyte name);
	private delegate void Uniform1uiDelegate(int location, uint v0);
	private delegate void Uniform2uiDelegate(int location, uint v0, uint v1);
	private delegate void Uniform3uiDelegate(int location, uint v0, uint v1, uint v2);
	private delegate void Uniform4uiDelegate(int location, uint v0, uint v1, uint v2, uint v3);
	private delegate void Uniform1uivDelegate(int location, int count, in uint value);
	private delegate void Uniform2uivDelegate(int location, int count, in uint value);
	private delegate void Uniform3uivDelegate(int location, int count, in uint value);
	private delegate void Uniform4uivDelegate(int location, int count, in uint value);
	private delegate void TexParameterIivDelegate(TextureTarget target, TextureParameterName pname, in int @params);
	private delegate void TexParameterIuivDelegate(TextureTarget target, TextureParameterName pname, in uint @params);
	private delegate void GetTexParameterIivDelegate(TextureTarget target, GetTextureParameter pname, out int @params);
	private delegate void GetTexParameterIuivDelegate(TextureTarget target, GetTextureParameter pname, out uint @params);
	private delegate void ClearBufferivDelegate(BufferType buffer, int drawbuffer, in int value);
	private delegate void ClearBufferuivDelegate(BufferType buffer, int drawbuffer, in uint value);
	private delegate void ClearBufferfvDelegate(BufferType buffer, int drawbuffer, in float value);
	private delegate void ClearBufferfiDelegate(BufferType buffer, int drawbuffer, float depth, int stencil);
	private delegate IntPtr GetStringiDelegate(StringName name, uint index);
	[return: MarshalAs(UnmanagedType.I1)]
	private delegate bool IsRenderbufferDelegate(uint renderbuffer);
	private delegate void BindRenderbufferDelegate(RenderbufferTarget target, uint renderbuffer);
	private delegate void DeleteRenderbuffersDelegate(int n, in uint renderbuffers);
	private delegate void GenRenderbuffersDelegate(int n, out uint renderbuffers);
	private delegate void RenderbufferStorageDelegate(RenderbufferTarget target, InternalFormat internalformat, int width, int height);
	private delegate void GetRenderbufferParameterivDelegate(RenderbufferTarget target, RenderbufferParameterName pname, out int @params);
	[return: MarshalAs(UnmanagedType.I1)]
	private delegate bool IsFramebufferDelegate(uint framebuffer);
	private delegate void BindFramebufferDelegate(FramebufferTarget target, uint framebuffer);
	private delegate void DeleteFramebuffersDelegate(int n, in uint framebuffers);
	private delegate void GenFramebuffersDelegate(int n, out uint framebuffers);
	private delegate FramebufferStatus CheckFramebufferStatusDelegate(FramebufferTarget target);
	private delegate void FramebufferTexture1DDelegate(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level);
	private delegate void FramebufferTexture2DDelegate(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level);
	private delegate void FramebufferTexture3DDelegate(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level, int zoffset);
	private delegate void FramebufferRenderbufferDelegate(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, uint renderbuffer);
	private delegate void GetFramebufferAttachmentParameterivDelegate(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, out int @params);
	private delegate void GenerateMipmapDelegate(TextureTarget target);
	private delegate void BlitFramebufferDelegate(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter);
	private delegate void RenderbufferStorageMultisampleDelegate(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height);
	private delegate void FramebufferTextureLayerDelegate(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level, int layer);
	private delegate IntPtr MapBufferRangeDelegate(BufferTarget target, IntPtr offset, nint length, MapBufferAccessMask access);
	private delegate void FlushMappedBufferRangeDelegate(BufferTarget target, IntPtr offset, nint length);
	private delegate void BindVertexArrayDelegate(uint array);
	private delegate void DeleteVertexArraysDelegate(int n, in uint arrays);
	private delegate void GenVertexArraysDelegate(int n, out uint arrays);
	[return: MarshalAs(UnmanagedType.I1)]
	private delegate bool IsVertexArrayDelegate(uint array);
	private delegate void DrawArraysInstancedDelegate(PrimitiveType mode, int first, int count, int instancecount);
	private delegate void DrawElementsInstancedDelegate(PrimitiveType mode, int count, DrawElementsType type, in byte indices, int instancecount);
	private delegate void TexBufferDelegate(TextureTarget target, SizedInternalFormat internalformat, uint buffer);
	private delegate void PrimitiveRestartIndexDelegate(uint index);
	private delegate void CopyBufferSubDataDelegate(CopyBufferSubDataTarget readTarget, CopyBufferSubDataTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, nint size);
	private delegate void GetUniformIndicesDelegate(uint program, int uniformCount, in IntPtr uniformNames, out uint uniformIndices);
	private delegate void GetActiveUniformsivDelegate(uint program, int uniformCount, in uint uniformIndices, UniformPName pname, out int @params);
	private delegate void GetActiveUniformNameDelegate(uint program, uint uniformIndex, int bufSize, out int length, out sbyte uniformName);
	private delegate uint GetUniformBlockIndexDelegate(uint program, in sbyte uniformBlockName);
	private delegate void GetActiveUniformBlockivDelegate(uint program, uint uniformBlockIndex, UniformBlockPName pname, out int @params);
	private delegate void GetActiveUniformBlockNameDelegate(uint program, uint uniformBlockIndex, int bufSize, out int length, out sbyte uniformBlockName);
	private delegate void UniformBlockBindingDelegate(uint program, uint uniformBlockIndex, uint uniformBlockBinding);
	private delegate void DrawElementsBaseVertexDelegate(PrimitiveType mode, int count, DrawElementsType type, in byte indices, int basevertex);
	private delegate void DrawRangeElementsBaseVertexDelegate(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, in byte indices, int basevertex);
	private delegate void DrawElementsInstancedBaseVertexDelegate(PrimitiveType mode, int count, DrawElementsType type, in byte indices, int instancecount, int basevertex);
	private delegate void MultiDrawElementsBaseVertexDelegate(PrimitiveType mode, in int count, DrawElementsType type, in IntPtr indices, int drawcount, in int basevertex);
	private delegate void ProvokingVertexDelegate(VertexProvokingMode mode);
	private delegate nint FenceSyncDelegate(SyncCondition condition, SyncBehaviorFlags flags);
	[return: MarshalAs(UnmanagedType.I1)]
	private delegate bool IsSyncDelegate(nint sync);
	private delegate void DeleteSyncDelegate(nint sync);
	private delegate SyncStatus ClientWaitSyncDelegate(nint sync, SyncObjectMask flags, ulong timeout);
	private delegate void WaitSyncDelegate(nint sync, SyncBehaviorFlags flags, ulong timeout);
	private delegate void GetInteger64vDelegate(GetPName pname, out long data);
	private delegate void GetSyncivDelegate(nint sync, SyncParameterName pname, int count, out int length, out int values);
	private delegate void GetInteger64i_vDelegate(GetPName target, uint index, out long data);
	private delegate void GetBufferParameteri64vDelegate(BufferTarget target, BufferPNameARB pname, out long @params);
	private delegate void FramebufferTextureDelegate(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level);
	private delegate void TexImage2DMultisampleDelegate(TextureTarget target, int samples, InternalFormat internalformat, int width, int height, [MarshalAs(UnmanagedType.I1)] bool fixedsamplelocations);
	private delegate void TexImage3DMultisampleDelegate(TextureTarget target, int samples, InternalFormat internalformat, int width, int height, int depth, [MarshalAs(UnmanagedType.I1)] bool fixedsamplelocations);
	private delegate void GetMultisamplefvDelegate(GetMultisamplePNameNV pname, uint index, out float val);
	private delegate void SampleMaskiDelegate(uint maskNumber, uint mask);
	private delegate void BindFragDataLocationIndexedDelegate(uint program, uint colorNumber, uint index, in sbyte name);
	private delegate int GetFragDataIndexDelegate(uint program, in sbyte name);
	private delegate void GenSamplersDelegate(int count, out uint samplers);
	private delegate void DeleteSamplersDelegate(int count, in uint samplers);
	[return: MarshalAs(UnmanagedType.I1)]
	private delegate bool IsSamplerDelegate(uint sampler);
	private delegate void BindSamplerDelegate(uint unit, uint sampler);
	private delegate void SamplerParameteriDelegate(uint sampler, SamplerParameterI pname, int param);
	private delegate void SamplerParameterivDelegate(uint sampler, SamplerParameterI pname, in int param);
	private delegate void SamplerParameterfDelegate(uint sampler, SamplerParameterF pname, float param);
	private delegate void SamplerParameterfvDelegate(uint sampler, SamplerParameterF pname, in float param);
	private delegate void SamplerParameterIivDelegate(uint sampler, SamplerParameterI pname, in int param);
	private delegate void SamplerParameterIuivDelegate(uint sampler, SamplerParameterI pname, in uint param);
	private delegate void GetSamplerParameterivDelegate(uint sampler, SamplerParameterI pname, out int @params);
	private delegate void GetSamplerParameterIivDelegate(uint sampler, SamplerParameterI pname, out int @params);
	private delegate void GetSamplerParameterfvDelegate(uint sampler, SamplerParameterF pname, out float @params);
	private delegate void GetSamplerParameterIuivDelegate(uint sampler, SamplerParameterI pname, out uint @params);
	private delegate void QueryCounterDelegate(uint id, QueryCounterTarget target);
	private delegate void GetQueryObjecti64vDelegate(uint id, QueryObjectParameterName pname, out long @params);
	private delegate void GetQueryObjectui64vDelegate(uint id, QueryObjectParameterName pname, out ulong @params);
	private delegate void VertexAttribDivisorDelegate(uint index, uint divisor);
	private delegate void VertexAttribP1uiDelegate(uint index, VertexAttribPointerType type, [MarshalAs(UnmanagedType.I1)] bool normalized, uint value);
	private delegate void VertexAttribP1uivDelegate(uint index, VertexAttribPointerType type, [MarshalAs(UnmanagedType.I1)] bool normalized, in uint value);
	private delegate void VertexAttribP2uiDelegate(uint index, VertexAttribPointerType type, [MarshalAs(UnmanagedType.I1)] bool normalized, uint value);
	private delegate void VertexAttribP2uivDelegate(uint index, VertexAttribPointerType type, [MarshalAs(UnmanagedType.I1)] bool normalized, in uint value);
	private delegate void VertexAttribP3uiDelegate(uint index, VertexAttribPointerType type, [MarshalAs(UnmanagedType.I1)] bool normalized, uint value);
	private delegate void VertexAttribP3uivDelegate(uint index, VertexAttribPointerType type, [MarshalAs(UnmanagedType.I1)] bool normalized, in uint value);
	private delegate void VertexAttribP4uiDelegate(uint index, VertexAttribPointerType type, [MarshalAs(UnmanagedType.I1)] bool normalized, uint value);
	private delegate void VertexAttribP4uivDelegate(uint index, VertexAttribPointerType type, [MarshalAs(UnmanagedType.I1)] bool normalized, in uint value);
	private delegate void MinSampleShadingDelegate(float value);
	private delegate void BlendEquationiDelegate(uint buf, BlendEquationModeEXT mode);
	private delegate void BlendEquationSeparateiDelegate(uint buf, BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha);
	private delegate void BlendFunciDelegate(uint buf, BlendingFactor src, BlendingFactor dst);
	private delegate void BlendFuncSeparateiDelegate(uint buf, BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha);
	private delegate void DrawArraysIndirectDelegate(PrimitiveType mode, in byte indirect);
	private delegate void DrawElementsIndirectDelegate(PrimitiveType mode, DrawElementsType type, in byte indirect);
	private delegate void Uniform1dDelegate(int location, double x);
	private delegate void Uniform2dDelegate(int location, double x, double y);
	private delegate void Uniform3dDelegate(int location, double x, double y, double z);
	private delegate void Uniform4dDelegate(int location, double x, double y, double z, double w);
	private delegate void Uniform1dvDelegate(int location, int count, in double value);
	private delegate void Uniform2dvDelegate(int location, int count, in double value);
	private delegate void Uniform3dvDelegate(int location, int count, in double value);
	private delegate void Uniform4dvDelegate(int location, int count, in double value);
	private delegate void UniformMatrix2dvDelegate(int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, in double value);
	private delegate void UniformMatrix3dvDelegate(int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, in double value);
	private delegate void UniformMatrix4dvDelegate(int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, in double value);
	private delegate void UniformMatrix2x3dvDelegate(int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, in double value);
	private delegate void UniformMatrix2x4dvDelegate(int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, in double value);
	private delegate void UniformMatrix3x2dvDelegate(int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, in double value);
	private delegate void UniformMatrix3x4dvDelegate(int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, in double value);
	private delegate void UniformMatrix4x2dvDelegate(int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, in double value);
	private delegate void UniformMatrix4x3dvDelegate(int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, in double value);
	private delegate void GetUniformdvDelegate(uint program, int location, out double @params);
	private delegate int GetSubroutineUniformLocationDelegate(uint program, ShaderType shadertype, in sbyte name);
	private delegate uint GetSubroutineIndexDelegate(uint program, ShaderType shadertype, in sbyte name);
	private delegate void GetActiveSubroutineUniformivDelegate(uint program, ShaderType shadertype, uint index, SubroutineParameterName pname, out int values);
	private delegate void GetActiveSubroutineUniformNameDelegate(uint program, ShaderType shadertype, uint index, int bufSize, out int length, out sbyte name);
	private delegate void GetActiveSubroutineNameDelegate(uint program, ShaderType shadertype, uint index, int bufSize, out int length, out sbyte name);
	private delegate void UniformSubroutinesuivDelegate(ShaderType shadertype, int count, in uint indices);
	private delegate void GetUniformSubroutineuivDelegate(ShaderType shadertype, int location, out uint @params);
	private delegate void GetProgramStageivDelegate(uint program, ShaderType shadertype, ProgramStagePName pname, out int values);
	private delegate void PatchParameteriDelegate(PatchParameterName pname, int value);
	private delegate void PatchParameterfvDelegate(PatchParameterName pname, in float values);
	private delegate void BindTransformFeedbackDelegate(BindTransformFeedbackTarget target, uint id);
	private delegate void DeleteTransformFeedbacksDelegate(int n, in uint ids);
	private delegate void GenTransformFeedbacksDelegate(int n, out uint ids);
	[return: MarshalAs(UnmanagedType.I1)]
	private delegate bool IsTransformFeedbackDelegate(uint id);
	private delegate void PauseTransformFeedbackDelegate();
	private delegate void ResumeTransformFeedbackDelegate();
	private delegate void DrawTransformFeedbackDelegate(PrimitiveType mode, uint id);
	private delegate void DrawTransformFeedbackStreamDelegate(PrimitiveType mode, uint id, uint stream);
	private delegate void BeginQueryIndexedDelegate(QueryTarget target, uint index, uint id);
	private delegate void EndQueryIndexedDelegate(QueryTarget target, uint index);
	private delegate void GetQueryIndexedivDelegate(QueryTarget target, uint index, QueryParameterName pname, out int @params);
	private delegate void ReleaseShaderCompilerDelegate();
	private delegate void ShaderBinaryDelegate(int count, in uint shaders, ShaderBinaryFormat binaryFormat, in byte binary, int length);
	private delegate void GetShaderPrecisionFormatDelegate(ShaderType shadertype, PrecisionType precisiontype, out int range, out int precision);
	private delegate void DepthRangefDelegate(float n, float f);
	private delegate void ClearDepthfDelegate(float d);
	private delegate void GetProgramBinaryDelegate(uint program, int bufSize, out int length, out uint binaryFormat, out byte binary);
	private delegate void ProgramBinaryDelegate(uint program, uint binaryFormat, in byte binary, int length);
	private delegate void ProgramParameteriDelegate(uint program, ProgramParameterPName pname, int value);
	private delegate void UseProgramStagesDelegate(uint pipeline, UseProgramStageMask stages, uint program);
	private delegate void ActiveShaderProgramDelegate(uint pipeline, uint program);
	private delegate uint CreateShaderProgramvDelegate(ShaderType type, int count, in IntPtr strings);
	private delegate void BindProgramPipelineDelegate(uint pipeline);
	private delegate void DeleteProgramPipelinesDelegate(int n, in uint pipelines);
	private delegate void GenProgramPipelinesDelegate(int n, out uint pipelines);
	[return: MarshalAs(UnmanagedType.I1)]
	private delegate bool IsProgramPipelineDelegate(uint pipeline);
	private delegate void GetProgramPipelineivDelegate(uint pipeline, PipelineParameterName pname, out int @params);
	private delegate void ProgramUniform1iDelegate(uint program, int location, int v0);
	private delegate void ProgramUniform1ivDelegate(uint program, int location, int count, in int value);
	private delegate void ProgramUniform1fDelegate(uint program, int location, float v0);
	private delegate void ProgramUniform1fvDelegate(uint program, int location, int count, in float value);
	private delegate void ProgramUniform1dDelegate(uint program, int location, double v0);
	private delegate void ProgramUniform1dvDelegate(uint program, int location, int count, in double value);
	private delegate void ProgramUniform1uiDelegate(uint program, int location, uint v0);
	private delegate void ProgramUniform1uivDelegate(uint program, int location, int count, in uint value);
	private delegate void ProgramUniform2iDelegate(uint program, int location, int v0, int v1);
	private delegate void ProgramUniform2ivDelegate(uint program, int location, int count, in int value);
	private delegate void ProgramUniform2fDelegate(uint program, int location, float v0, float v1);
	private delegate void ProgramUniform2fvDelegate(uint program, int location, int count, in float value);
	private delegate void ProgramUniform2dDelegate(uint program, int location, double v0, double v1);
	private delegate void ProgramUniform2dvDelegate(uint program, int location, int count, in double value);
	private delegate void ProgramUniform2uiDelegate(uint program, int location, uint v0, uint v1);
	private delegate void ProgramUniform2uivDelegate(uint program, int location, int count, in uint value);
	private delegate void ProgramUniform3iDelegate(uint program, int location, int v0, int v1, int v2);
	private delegate void ProgramUniform3ivDelegate(uint program, int location, int count, in int value);
	private delegate void ProgramUniform3fDelegate(uint program, int location, float v0, float v1, float v2);
	private delegate void ProgramUniform3fvDelegate(uint program, int location, int count, in float value);
	private delegate void ProgramUniform3dDelegate(uint program, int location, double v0, double v1, double v2);
	private delegate void ProgramUniform3dvDelegate(uint program, int location, int count, in double value);
	private delegate void ProgramUniform3uiDelegate(uint program, int location, uint v0, uint v1, uint v2);
	private delegate void ProgramUniform3uivDelegate(uint program, int location, int count, in uint value);
	private delegate void ProgramUniform4iDelegate(uint program, int location, int v0, int v1, int v2, int v3);
	private delegate void ProgramUniform4ivDelegate(uint program, int location, int count, in int value);
	private delegate void ProgramUniform4fDelegate(uint program, int location, float v0, float v1, float v2, float v3);
	private delegate void ProgramUniform4fvDelegate(uint program, int location, int count, in float value);
	private delegate void ProgramUniform4dDelegate(uint program, int location, double v0, double v1, double v2, double v3);
	private delegate void ProgramUniform4dvDelegate(uint program, int location, int count, in double value);
	private delegate void ProgramUniform4uiDelegate(uint program, int location, uint v0, uint v1, uint v2, uint v3);
	private delegate void ProgramUniform4uivDelegate(uint program, int location, int count, in uint value);
	private delegate void ProgramUniformMatrix2fvDelegate(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, in float value);
	private delegate void ProgramUniformMatrix3fvDelegate(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, in float value);
	private delegate void ProgramUniformMatrix4fvDelegate(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, in float value);
	private delegate void ProgramUniformMatrix2dvDelegate(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, in double value);
	private delegate void ProgramUniformMatrix3dvDelegate(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, in double value);
	private delegate void ProgramUniformMatrix4dvDelegate(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, in double value);
	private delegate void ProgramUniformMatrix2x3fvDelegate(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, in float value);
	private delegate void ProgramUniformMatrix3x2fvDelegate(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, in float value);
	private delegate void ProgramUniformMatrix2x4fvDelegate(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, in float value);
	private delegate void ProgramUniformMatrix4x2fvDelegate(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, in float value);
	private delegate void ProgramUniformMatrix3x4fvDelegate(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, in float value);
	private delegate void ProgramUniformMatrix4x3fvDelegate(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, in float value);
	private delegate void ProgramUniformMatrix2x3dvDelegate(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, in double value);
	private delegate void ProgramUniformMatrix3x2dvDelegate(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, in double value);
	private delegate void ProgramUniformMatrix2x4dvDelegate(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, in double value);
	private delegate void ProgramUniformMatrix4x2dvDelegate(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, in double value);
	private delegate void ProgramUniformMatrix3x4dvDelegate(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, in double value);
	private delegate void ProgramUniformMatrix4x3dvDelegate(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, in double value);
	private delegate void ValidateProgramPipelineDelegate(uint pipeline);
	private delegate void GetProgramPipelineInfoLogDelegate(uint pipeline, int bufSize, out int length, out sbyte infoLog);
	private delegate void VertexAttribL1dDelegate(uint index, double x);
	private delegate void VertexAttribL2dDelegate(uint index, double x, double y);
	private delegate void VertexAttribL3dDelegate(uint index, double x, double y, double z);
	private delegate void VertexAttribL4dDelegate(uint index, double x, double y, double z, double w);
	private delegate void VertexAttribL1dvDelegate(uint index, in double v);
	private delegate void VertexAttribL2dvDelegate(uint index, in double v);
	private delegate void VertexAttribL3dvDelegate(uint index, in double v);
	private delegate void VertexAttribL4dvDelegate(uint index, in double v);
	private delegate void VertexAttribLPointerDelegate(uint index, int size, VertexAttribLType type, int stride, in byte pointer);
	private delegate void GetVertexAttribLdvDelegate(uint index, VertexAttribEnum pname, out double @params);
	private delegate void ViewportArrayvDelegate(uint first, int count, in float v);
	private delegate void ViewportIndexedfDelegate(uint index, float x, float y, float w, float h);
	private delegate void ViewportIndexedfvDelegate(uint index, in float v);
	private delegate void ScissorArrayvDelegate(uint first, int count, in int v);
	private delegate void ScissorIndexedDelegate(uint index, int left, int bottom, int width, int height);
	private delegate void ScissorIndexedvDelegate(uint index, in int v);
	private delegate void DepthRangeArrayvDelegate(uint first, int count, in double v);
	private delegate void DepthRangeIndexedDelegate(uint index, double n, double f);
	private delegate void GetFloati_vDelegate(GetPName target, uint index, out float data);
	private delegate void GetDoublei_vDelegate(GetPName target, uint index, out double data);
	private delegate void DrawArraysInstancedBaseInstanceDelegate(PrimitiveType mode, int first, int count, int instancecount, uint baseinstance);
	private delegate void DrawElementsInstancedBaseInstanceDelegate(PrimitiveType mode, int count, DrawElementsType type, in byte indices, int instancecount, uint baseinstance);
	private delegate void DrawElementsInstancedBaseVertexBaseInstanceDelegate(PrimitiveType mode, int count, DrawElementsType type, in byte indices, int instancecount, int basevertex, uint baseinstance);
	private delegate void GetInternalformativDelegate(TextureTarget target, InternalFormat internalformat, InternalFormatPName pname, int count, out int @params);
	private delegate void GetActiveAtomicCounterBufferivDelegate(uint program, uint bufferIndex, AtomicCounterBufferPName pname, out int @params);
	private delegate void BindImageTextureDelegate(uint unit, uint texture, int level, [MarshalAs(UnmanagedType.I1)] bool layered, int layer, BufferAccessARB access, InternalFormat format);
	private delegate void MemoryBarrierDelegate(MemoryBarrierMask barriers);
	private delegate void TexStorage1DDelegate(TextureTarget target, int levels, SizedInternalFormat internalformat, int width);
	private delegate void TexStorage2DDelegate(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height);
	private delegate void TexStorage3DDelegate(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height, int depth);
	private delegate void DrawTransformFeedbackInstancedDelegate(PrimitiveType mode, uint id, int instancecount);
	private delegate void DrawTransformFeedbackStreamInstancedDelegate(PrimitiveType mode, uint id, uint stream, int instancecount);
	private delegate void ClearBufferDataDelegate(BufferStorageTarget target, SizedInternalFormat internalformat, PixelFormat format, PixelType type, in byte data);
	private delegate void ClearBufferSubDataDelegate(BufferTarget target, SizedInternalFormat internalformat, IntPtr offset, nint size, PixelFormat format, PixelType type, in byte data);
	private delegate void DispatchComputeDelegate(uint num_groups_x, uint num_groups_y, uint num_groups_z);
	private delegate void DispatchComputeIndirectDelegate(IntPtr indirect);
	private delegate void CopyImageSubDataDelegate(uint srcName, CopyImageSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, CopyImageSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth);
	private delegate void FramebufferParameteriDelegate(FramebufferTarget target, FramebufferParameterName pname, int param);
	private delegate void GetFramebufferParameterivDelegate(FramebufferTarget target, FramebufferAttachmentParameterName pname, out int @params);
	private delegate void GetInternalformati64vDelegate(TextureTarget target, InternalFormat internalformat, InternalFormatPName pname, int count, out long @params);
	private delegate void InvalidateTexSubImageDelegate(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth);
	private delegate void InvalidateTexImageDelegate(uint texture, int level);
	private delegate void InvalidateBufferSubDataDelegate(uint buffer, IntPtr offset, nint length);
	private delegate void InvalidateBufferDataDelegate(uint buffer);
	private delegate void InvalidateFramebufferDelegate(FramebufferTarget target, int numAttachments, in uint attachments);
	private delegate void InvalidateSubFramebufferDelegate(FramebufferTarget target, int numAttachments, in uint attachments, int x, int y, int width, int height);
	private delegate void MultiDrawArraysIndirectDelegate(PrimitiveType mode, in byte indirect, int drawcount, int stride);
	private delegate void MultiDrawElementsIndirectDelegate(PrimitiveType mode, DrawElementsType type, in byte indirect, int drawcount, int stride);
	private delegate void GetProgramInterfaceivDelegate(uint program, ProgramInterface programInterface, ProgramInterfacePName pname, out int @params);
	private delegate uint GetProgramResourceIndexDelegate(uint program, ProgramInterface programInterface, in sbyte name);
	private delegate void GetProgramResourceNameDelegate(uint program, ProgramInterface programInterface, uint index, int bufSize, out int length, out sbyte name);
	private delegate void GetProgramResourceivDelegate(uint program, ProgramInterface programInterface, uint index, int propCount, in uint props, int count, out int length, out int @params);
	private delegate int GetProgramResourceLocationDelegate(uint program, ProgramInterface programInterface, in sbyte name);
	private delegate int GetProgramResourceLocationIndexDelegate(uint program, ProgramInterface programInterface, in sbyte name);
	private delegate void ShaderStorageBlockBindingDelegate(uint program, uint storageBlockIndex, uint storageBlockBinding);
	private delegate void TexBufferRangeDelegate(TextureTarget target, SizedInternalFormat internalformat, uint buffer, IntPtr offset, nint size);
	private delegate void TexStorage2DMultisampleDelegate(TextureTarget target, int samples, SizedInternalFormat internalformat, int width, int height, [MarshalAs(UnmanagedType.I1)] bool fixedsamplelocations);
	private delegate void TexStorage3DMultisampleDelegate(TextureTarget target, int samples, SizedInternalFormat internalformat, int width, int height, int depth, [MarshalAs(UnmanagedType.I1)] bool fixedsamplelocations);
	private delegate void TextureViewDelegate(uint texture, TextureTarget target, uint origtexture, SizedInternalFormat internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers);
	private delegate void BindVertexBufferDelegate(uint bindingindex, uint buffer, IntPtr offset, int stride);
	private delegate void VertexAttribFormatDelegate(uint attribindex, int size, VertexAttribType type, [MarshalAs(UnmanagedType.I1)] bool normalized, uint relativeoffset);
	private delegate void VertexAttribIFormatDelegate(uint attribindex, int size, VertexAttribIType type, uint relativeoffset);
	private delegate void VertexAttribLFormatDelegate(uint attribindex, int size, VertexAttribLType type, uint relativeoffset);
	private delegate void VertexAttribBindingDelegate(uint attribindex, uint bindingindex);
	private delegate void VertexBindingDivisorDelegate(uint bindingindex, uint divisor);
	private delegate void GetPointervDelegate(GetPointervPName pname, out IntPtr @params);
	private delegate void BufferStorageDelegate(BufferStorageTarget target, nint size, in byte data, BufferStorageMask flags);
	private delegate void ClearTexImageDelegate(uint texture, int level, PixelFormat format, PixelType type, in byte data);
	private delegate void ClearTexSubImageDelegate(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, in byte data);
	private delegate void BindBuffersBaseDelegate(BufferTarget target, uint first, int count, in uint buffers);
	private delegate void BindBuffersRangeDelegate(BufferTarget target, uint first, int count, in uint buffers, in IntPtr offsets, in nint sizes);
	private delegate void BindTexturesDelegate(uint first, int count, in uint textures);
	private delegate void BindSamplersDelegate(uint first, int count, in uint samplers);
	private delegate void BindImageTexturesDelegate(uint first, int count, in uint textures);
	private delegate void BindVertexBuffersDelegate(uint first, int count, in uint buffers, in IntPtr offsets, in int strides);
	private delegate void ClipControlDelegate(ClipControlOrigin origin, ClipControlDepth depth);
	private delegate void CreateTransformFeedbacksDelegate(int n, out uint ids);
	private delegate void TransformFeedbackBufferBaseDelegate(uint xfb, uint index, uint buffer);
	private delegate void TransformFeedbackBufferRangeDelegate(uint xfb, uint index, uint buffer, IntPtr offset, nint size);
	private delegate void GetTransformFeedbackivDelegate(uint xfb, TransformFeedbackPName pname, out int param);
	private delegate void GetTransformFeedbacki_vDelegate(uint xfb, TransformFeedbackPName pname, uint index, out int param);
	private delegate void GetTransformFeedbacki64_vDelegate(uint xfb, TransformFeedbackPName pname, uint index, out long param);
	private delegate void CreateBuffersDelegate(int n, out uint buffers);
	private delegate void NamedBufferStorageDelegate(uint buffer, nint size, in byte data, BufferStorageMask flags);
	private delegate void NamedBufferDataDelegate(uint buffer, nint size, in byte data, VertexBufferObjectUsage usage);
	private delegate void NamedBufferSubDataDelegate(uint buffer, IntPtr offset, nint size, in byte data);
	private delegate void CopyNamedBufferSubDataDelegate(uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, nint size);
	private delegate void ClearNamedBufferDataDelegate(uint buffer, SizedInternalFormat internalformat, PixelFormat format, PixelType type, in byte data);
	private delegate void ClearNamedBufferSubDataDelegate(uint buffer, SizedInternalFormat internalformat, IntPtr offset, nint size, PixelFormat format, PixelType type, in byte data);
	private delegate IntPtr MapNamedBufferDelegate(uint buffer, BufferAccessARB access);
	private delegate IntPtr MapNamedBufferRangeDelegate(uint buffer, IntPtr offset, nint length, MapBufferAccessMask access);
	[return: MarshalAs(UnmanagedType.I1)]
	private delegate bool UnmapNamedBufferDelegate(uint buffer);
	private delegate void FlushMappedNamedBufferRangeDelegate(uint buffer, IntPtr offset, nint length);
	private delegate void GetNamedBufferParameterivDelegate(uint buffer, BufferPNameARB pname, out int @params);
	private delegate void GetNamedBufferParameteri64vDelegate(uint buffer, BufferPNameARB pname, out long @params);
	private delegate void GetNamedBufferPointervDelegate(uint buffer, BufferPointerNameARB pname, out IntPtr @params);
	private delegate void GetNamedBufferSubDataDelegate(uint buffer, IntPtr offset, nint size, out byte data);
	private delegate void CreateFramebuffersDelegate(int n, out uint framebuffers);
	private delegate void NamedFramebufferRenderbufferDelegate(uint framebuffer, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, uint renderbuffer);
	private delegate void NamedFramebufferParameteriDelegate(uint framebuffer, FramebufferParameterName pname, int param);
	private delegate void NamedFramebufferTextureDelegate(uint framebuffer, FramebufferAttachment attachment, uint texture, int level);
	private delegate void NamedFramebufferTextureLayerDelegate(uint framebuffer, FramebufferAttachment attachment, uint texture, int level, int layer);
	private delegate void NamedFramebufferDrawBufferDelegate(uint framebuffer, ColorBuffer buf);
	private delegate void NamedFramebufferDrawBuffersDelegate(uint framebuffer, int n, in uint bufs);
	private delegate void NamedFramebufferReadBufferDelegate(uint framebuffer, ColorBuffer src);
	private delegate void InvalidateNamedFramebufferDataDelegate(uint framebuffer, int numAttachments, in uint attachments);
	private delegate void InvalidateNamedFramebufferSubDataDelegate(uint framebuffer, int numAttachments, in uint attachments, int x, int y, int width, int height);
	private delegate void ClearNamedFramebufferivDelegate(uint framebuffer, BufferType buffer, int drawbuffer, in int value);
	private delegate void ClearNamedFramebufferuivDelegate(uint framebuffer, BufferType buffer, int drawbuffer, in uint value);
	private delegate void ClearNamedFramebufferfvDelegate(uint framebuffer, BufferType buffer, int drawbuffer, in float value);
	private delegate void ClearNamedFramebufferfiDelegate(uint framebuffer, BufferType buffer, int drawbuffer, float depth, int stencil);
	private delegate void BlitNamedFramebufferDelegate(uint readFramebuffer, uint drawFramebuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter);
	private delegate FramebufferStatus CheckNamedFramebufferStatusDelegate(uint framebuffer, FramebufferTarget target);
	private delegate void GetNamedFramebufferParameterivDelegate(uint framebuffer, GetFramebufferParameter pname, out int param);
	private delegate void GetNamedFramebufferAttachmentParameterivDelegate(uint framebuffer, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, out int @params);
	private delegate void CreateRenderbuffersDelegate(int n, out uint renderbuffers);
	private delegate void NamedRenderbufferStorageDelegate(uint renderbuffer, InternalFormat internalformat, int width, int height);
	private delegate void NamedRenderbufferStorageMultisampleDelegate(uint renderbuffer, int samples, InternalFormat internalformat, int width, int height);
	private delegate void GetNamedRenderbufferParameterivDelegate(uint renderbuffer, RenderbufferParameterName pname, out int @params);
	private delegate void CreateTexturesDelegate(TextureTarget target, int n, out uint textures);
	private delegate void TextureBufferDelegate(uint texture, SizedInternalFormat internalformat, uint buffer);
	private delegate void TextureBufferRangeDelegate(uint texture, SizedInternalFormat internalformat, uint buffer, IntPtr offset, nint size);
	private delegate void TextureStorage1DDelegate(uint texture, int levels, SizedInternalFormat internalformat, int width);
	private delegate void TextureStorage2DDelegate(uint texture, int levels, SizedInternalFormat internalformat, int width, int height);
	private delegate void TextureStorage3DDelegate(uint texture, int levels, SizedInternalFormat internalformat, int width, int height, int depth);
	private delegate void TextureStorage2DMultisampleDelegate(uint texture, int samples, SizedInternalFormat internalformat, int width, int height, [MarshalAs(UnmanagedType.I1)] bool fixedsamplelocations);
	private delegate void TextureStorage3DMultisampleDelegate(uint texture, int samples, SizedInternalFormat internalformat, int width, int height, int depth, [MarshalAs(UnmanagedType.I1)] bool fixedsamplelocations);
	private delegate void TextureSubImage1DDelegate(uint texture, int level, int xoffset, int width, PixelFormat format, PixelType type, in byte pixels);
	private delegate void TextureSubImage2DDelegate(uint texture, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, in byte pixels);
	private delegate void TextureSubImage3DDelegate(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, in byte pixels);
	private delegate void CompressedTextureSubImage1DDelegate(uint texture, int level, int xoffset, int width, InternalFormat format, int imageSize, in byte data);
	private delegate void CompressedTextureSubImage2DDelegate(uint texture, int level, int xoffset, int yoffset, int width, int height, InternalFormat format, int imageSize, in byte data);
	private delegate void CompressedTextureSubImage3DDelegate(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, InternalFormat format, int imageSize, in byte data);
	private delegate void CopyTextureSubImage1DDelegate(uint texture, int level, int xoffset, int x, int y, int width);
	private delegate void CopyTextureSubImage2DDelegate(uint texture, int level, int xoffset, int yoffset, int x, int y, int width, int height);
	private delegate void CopyTextureSubImage3DDelegate(uint texture, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
	private delegate void TextureParameterfDelegate(uint texture, TextureParameterName pname, float param);
	private delegate void TextureParameterfvDelegate(uint texture, TextureParameterName pname, in float param);
	private delegate void TextureParameteriDelegate(uint texture, TextureParameterName pname, int param);
	private delegate void TextureParameterIivDelegate(uint texture, TextureParameterName pname, in int @params);
	private delegate void TextureParameterIuivDelegate(uint texture, TextureParameterName pname, in uint @params);
	private delegate void TextureParameterivDelegate(uint texture, TextureParameterName pname, in int param);
	private delegate void GenerateTextureMipmapDelegate(uint texture);
	private delegate void BindTextureUnitDelegate(uint unit, uint texture);
	private delegate void GetTextureImageDelegate(uint texture, int level, PixelFormat format, PixelType type, int bufSize, out byte pixels);
	private delegate void GetCompressedTextureImageDelegate(uint texture, int level, int bufSize, out byte pixels);
	private delegate void GetTextureLevelParameterfvDelegate(uint texture, int level, GetTextureParameter pname, out float @params);
	private delegate void GetTextureLevelParameterivDelegate(uint texture, int level, GetTextureParameter pname, out int @params);
	private delegate void GetTextureParameterfvDelegate(uint texture, GetTextureParameter pname, out float @params);
	private delegate void GetTextureParameterIivDelegate(uint texture, GetTextureParameter pname, out int @params);
	private delegate void GetTextureParameterIuivDelegate(uint texture, GetTextureParameter pname, out uint @params);
	private delegate void GetTextureParameterivDelegate(uint texture, GetTextureParameter pname, out int @params);
	private delegate void CreateVertexArraysDelegate(int n, out uint arrays);
	private delegate void DisableVertexArrayAttribDelegate(uint vaobj, uint index);
	private delegate void EnableVertexArrayAttribDelegate(uint vaobj, uint index);
	private delegate void VertexArrayElementBufferDelegate(uint vaobj, uint buffer);
	private delegate void VertexArrayVertexBufferDelegate(uint vaobj, uint bindingindex, uint buffer, IntPtr offset, int stride);
	private delegate void VertexArrayVertexBuffersDelegate(uint vaobj, uint first, int count, in uint buffers, in IntPtr offsets, in int strides);
	private delegate void VertexArrayAttribBindingDelegate(uint vaobj, uint attribindex, uint bindingindex);
	private delegate void VertexArrayAttribFormatDelegate(uint vaobj, uint attribindex, int size, VertexAttribType type, [MarshalAs(UnmanagedType.I1)] bool normalized, uint relativeoffset);
	private delegate void VertexArrayAttribIFormatDelegate(uint vaobj, uint attribindex, int size, VertexAttribIType type, uint relativeoffset);
	private delegate void VertexArrayAttribLFormatDelegate(uint vaobj, uint attribindex, int size, VertexAttribLType type, uint relativeoffset);
	private delegate void VertexArrayBindingDivisorDelegate(uint vaobj, uint bindingindex, uint divisor);
	private delegate void GetVertexArrayivDelegate(uint vaobj, VertexArrayPName pname, out int param);
	private delegate void GetVertexArrayIndexedivDelegate(uint vaobj, uint index, VertexArrayPName pname, out int param);
	private delegate void GetVertexArrayIndexed64ivDelegate(uint vaobj, uint index, VertexArrayPName pname, out long param);
	private delegate void CreateSamplersDelegate(int n, out uint samplers);
	private delegate void CreateProgramPipelinesDelegate(int n, out uint pipelines);
	private delegate void CreateQueriesDelegate(QueryTarget target, int n, out uint ids);
	private delegate void GetQueryBufferObjecti64vDelegate(uint id, uint buffer, QueryObjectParameterName pname, IntPtr offset);
	private delegate void GetQueryBufferObjectivDelegate(uint id, uint buffer, QueryObjectParameterName pname, IntPtr offset);
	private delegate void GetQueryBufferObjectui64vDelegate(uint id, uint buffer, QueryObjectParameterName pname, IntPtr offset);
	private delegate void GetQueryBufferObjectuivDelegate(uint id, uint buffer, QueryObjectParameterName pname, IntPtr offset);
	private delegate void MemoryBarrierByRegionDelegate(MemoryBarrierMask barriers);
	private delegate void GetTextureSubImageDelegate(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, int bufSize, out byte pixels);
	private delegate void GetCompressedTextureSubImageDelegate(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, out byte pixels);
	private delegate GraphicsResetStatus GetGraphicsResetStatusDelegate();
	private delegate void GetnCompressedTexImageDelegate(TextureTarget target, int lod, int bufSize, out byte pixels);
	private delegate void GetnTexImageDelegate(TextureTarget target, int level, PixelFormat format, PixelType type, int bufSize, out byte pixels);
	private delegate void GetnUniformdvDelegate(uint program, int location, int bufSize, out double @params);
	private delegate void GetnUniformfvDelegate(uint program, int location, int bufSize, out float @params);
	private delegate void GetnUniformivDelegate(uint program, int location, int bufSize, out int @params);
	private delegate void GetnUniformuivDelegate(uint program, int location, int bufSize, out uint @params);
	private delegate void ReadnPixelsDelegate(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, out byte data);
	private delegate void TextureBarrierDelegate();
	#endregion
	#region DelegateInstances
#pragma warning disable CS8618
	private static DebugMessageControlDelegate DebugMessageControlInstance;
	private static DebugMessageInsertDelegate DebugMessageInsertInstance;
	private static DebugMessageCallbackDelegate DebugMessageCallbackInstance;
	private static GetDebugMessageLogDelegate GetDebugMessageLogInstance;
	private static PushDebugGroupDelegate PushDebugGroupInstance;
	private static PopDebugGroupDelegate PopDebugGroupInstance;
	private static ObjectLabelDelegate ObjectLabelInstance;
	private static GetObjectLabelDelegate GetObjectLabelInstance;
	private static ObjectPtrLabelDelegate ObjectPtrLabelInstance;
	private static GetObjectPtrLabelDelegate GetObjectPtrLabelInstance;
	private static DebugMessageControlKHRDelegate DebugMessageControlKHRInstance;
	private static DebugMessageInsertKHRDelegate DebugMessageInsertKHRInstance;
	private static DebugMessageCallbackKHRDelegate DebugMessageCallbackKHRInstance;
	private static GetDebugMessageLogKHRDelegate GetDebugMessageLogKHRInstance;
	private static PushDebugGroupKHRDelegate PushDebugGroupKHRInstance;
	private static PopDebugGroupKHRDelegate PopDebugGroupKHRInstance;
	private static ObjectLabelKHRDelegate ObjectLabelKHRInstance;
	private static GetObjectLabelKHRDelegate GetObjectLabelKHRInstance;
	private static ObjectPtrLabelKHRDelegate ObjectPtrLabelKHRInstance;
	private static GetObjectPtrLabelKHRDelegate GetObjectPtrLabelKHRInstance;
	private static GetPointervKHRDelegate GetPointervKHRInstance;
	private static CullFaceDelegate CullFaceInstance;
	private static FrontFaceDelegate FrontFaceInstance;
	private static HintDelegate HintInstance;
	private static LineWidthDelegate LineWidthInstance;
	private static PointSizeDelegate PointSizeInstance;
	private static PolygonModeDelegate PolygonModeInstance;
	private static ScissorDelegate ScissorInstance;
	private static TexParameterfDelegate TexParameterfInstance;
	private static TexParameterfvDelegate TexParameterfvInstance;
	private static TexParameteriDelegate TexParameteriInstance;
	private static TexParameterivDelegate TexParameterivInstance;
	private static TexImage1DDelegate TexImage1DInstance;
	private static TexImage2DDelegate TexImage2DInstance;
	private static DrawBufferDelegate DrawBufferInstance;
	private static ClearDelegate ClearInstance;
	private static ClearColorDelegate ClearColorInstance;
	private static ClearStencilDelegate ClearStencilInstance;
	private static ClearDepthDelegate ClearDepthInstance;
	private static StencilMaskDelegate StencilMaskInstance;
	private static ColorMaskDelegate ColorMaskInstance;
	private static DepthMaskDelegate DepthMaskInstance;
	private static DisableDelegate DisableInstance;
	private static EnableDelegate EnableInstance;
	private static FinishDelegate FinishInstance;
	private static FlushDelegate FlushInstance;
	private static BlendFuncDelegate BlendFuncInstance;
	private static LogicOpDelegate LogicOpInstance;
	private static StencilFuncDelegate StencilFuncInstance;
	private static StencilOpDelegate StencilOpInstance;
	private static DepthFuncDelegate DepthFuncInstance;
	private static PixelStorefDelegate PixelStorefInstance;
	private static PixelStoreiDelegate PixelStoreiInstance;
	private static ReadBufferDelegate ReadBufferInstance;
	private static ReadPixelsDelegate ReadPixelsInstance;
	private static GetBooleanvDelegate GetBooleanvInstance;
	private static GetDoublevDelegate GetDoublevInstance;
	private static GetErrorDelegate GetErrorInstance;
	private static GetFloatvDelegate GetFloatvInstance;
	private static GetIntegervDelegate GetIntegervInstance;
	private static GetStringDelegate GetStringInstance;
	private static GetTexImageDelegate GetTexImageInstance;
	private static GetTexParameterfvDelegate GetTexParameterfvInstance;
	private static GetTexParameterivDelegate GetTexParameterivInstance;
	private static GetTexLevelParameterfvDelegate GetTexLevelParameterfvInstance;
	private static GetTexLevelParameterivDelegate GetTexLevelParameterivInstance;
	private static IsEnabledDelegate IsEnabledInstance;
	private static DepthRangeDelegate DepthRangeInstance;
	private static ViewportDelegate ViewportInstance;
	private static DrawArraysDelegate DrawArraysInstance;
	private static DrawElementsDelegate DrawElementsInstance;
	private static PolygonOffsetDelegate PolygonOffsetInstance;
	private static CopyTexImage1DDelegate CopyTexImage1DInstance;
	private static CopyTexImage2DDelegate CopyTexImage2DInstance;
	private static CopyTexSubImage1DDelegate CopyTexSubImage1DInstance;
	private static CopyTexSubImage2DDelegate CopyTexSubImage2DInstance;
	private static TexSubImage1DDelegate TexSubImage1DInstance;
	private static TexSubImage2DDelegate TexSubImage2DInstance;
	private static BindTextureDelegate BindTextureInstance;
	private static DeleteTexturesDelegate DeleteTexturesInstance;
	private static GenTexturesDelegate GenTexturesInstance;
	private static IsTextureDelegate IsTextureInstance;
	private static DrawRangeElementsDelegate DrawRangeElementsInstance;
	private static TexImage3DDelegate TexImage3DInstance;
	private static TexSubImage3DDelegate TexSubImage3DInstance;
	private static CopyTexSubImage3DDelegate CopyTexSubImage3DInstance;
	private static ActiveTextureDelegate ActiveTextureInstance;
	private static SampleCoverageDelegate SampleCoverageInstance;
	private static CompressedTexImage3DDelegate CompressedTexImage3DInstance;
	private static CompressedTexImage2DDelegate CompressedTexImage2DInstance;
	private static CompressedTexImage1DDelegate CompressedTexImage1DInstance;
	private static CompressedTexSubImage3DDelegate CompressedTexSubImage3DInstance;
	private static CompressedTexSubImage2DDelegate CompressedTexSubImage2DInstance;
	private static CompressedTexSubImage1DDelegate CompressedTexSubImage1DInstance;
	private static GetCompressedTexImageDelegate GetCompressedTexImageInstance;
	private static BlendFuncSeparateDelegate BlendFuncSeparateInstance;
	private static MultiDrawArraysDelegate MultiDrawArraysInstance;
	private static MultiDrawElementsDelegate MultiDrawElementsInstance;
	private static PointParameterfDelegate PointParameterfInstance;
	private static PointParameterfvDelegate PointParameterfvInstance;
	private static PointParameteriDelegate PointParameteriInstance;
	private static PointParameterivDelegate PointParameterivInstance;
	private static BlendColorDelegate BlendColorInstance;
	private static BlendEquationDelegate BlendEquationInstance;
	private static GenQueriesDelegate GenQueriesInstance;
	private static DeleteQueriesDelegate DeleteQueriesInstance;
	private static IsQueryDelegate IsQueryInstance;
	private static BeginQueryDelegate BeginQueryInstance;
	private static EndQueryDelegate EndQueryInstance;
	private static GetQueryivDelegate GetQueryivInstance;
	private static GetQueryObjectivDelegate GetQueryObjectivInstance;
	private static GetQueryObjectuivDelegate GetQueryObjectuivInstance;
	private static BindBufferDelegate BindBufferInstance;
	private static DeleteBuffersDelegate DeleteBuffersInstance;
	private static GenBuffersDelegate GenBuffersInstance;
	private static IsBufferDelegate IsBufferInstance;
	private static BufferDataDelegate BufferDataInstance;
	private static BufferSubDataDelegate BufferSubDataInstance;
	private static GetBufferSubDataDelegate GetBufferSubDataInstance;
	private static MapBufferDelegate MapBufferInstance;
	private static UnmapBufferDelegate UnmapBufferInstance;
	private static GetBufferParameterivDelegate GetBufferParameterivInstance;
	private static GetBufferPointervDelegate GetBufferPointervInstance;
	private static BlendEquationSeparateDelegate BlendEquationSeparateInstance;
	private static DrawBuffersDelegate DrawBuffersInstance;
	private static StencilOpSeparateDelegate StencilOpSeparateInstance;
	private static StencilFuncSeparateDelegate StencilFuncSeparateInstance;
	private static StencilMaskSeparateDelegate StencilMaskSeparateInstance;
	private static AttachShaderDelegate AttachShaderInstance;
	private static BindAttribLocationDelegate BindAttribLocationInstance;
	private static CompileShaderDelegate CompileShaderInstance;
	private static CreateProgramDelegate CreateProgramInstance;
	private static CreateShaderDelegate CreateShaderInstance;
	private static DeleteProgramDelegate DeleteProgramInstance;
	private static DeleteShaderDelegate DeleteShaderInstance;
	private static DetachShaderDelegate DetachShaderInstance;
	private static DisableVertexAttribArrayDelegate DisableVertexAttribArrayInstance;
	private static EnableVertexAttribArrayDelegate EnableVertexAttribArrayInstance;
	private static GetActiveAttribDelegate GetActiveAttribInstance;
	private static GetActiveUniformDelegate GetActiveUniformInstance;
	private static GetAttachedShadersDelegate GetAttachedShadersInstance;
	private static GetAttribLocationDelegate GetAttribLocationInstance;
	private static GetProgramivDelegate GetProgramivInstance;
	private static GetProgramInfoLogDelegate GetProgramInfoLogInstance;
	private static GetShaderivDelegate GetShaderivInstance;
	private static GetShaderInfoLogDelegate GetShaderInfoLogInstance;
	private static GetShaderSourceDelegate GetShaderSourceInstance;
	private static GetUniformLocationDelegate GetUniformLocationInstance;
	private static GetUniformfvDelegate GetUniformfvInstance;
	private static GetUniformivDelegate GetUniformivInstance;
	private static GetVertexAttribdvDelegate GetVertexAttribdvInstance;
	private static GetVertexAttribfvDelegate GetVertexAttribfvInstance;
	private static GetVertexAttribivDelegate GetVertexAttribivInstance;
	private static GetVertexAttribPointervDelegate GetVertexAttribPointervInstance;
	private static IsProgramDelegate IsProgramInstance;
	private static IsShaderDelegate IsShaderInstance;
	private static LinkProgramDelegate LinkProgramInstance;
	private static ShaderSourceDelegate ShaderSourceInstance;
	private static UseProgramDelegate UseProgramInstance;
	private static Uniform1fDelegate Uniform1fInstance;
	private static Uniform2fDelegate Uniform2fInstance;
	private static Uniform3fDelegate Uniform3fInstance;
	private static Uniform4fDelegate Uniform4fInstance;
	private static Uniform1iDelegate Uniform1iInstance;
	private static Uniform2iDelegate Uniform2iInstance;
	private static Uniform3iDelegate Uniform3iInstance;
	private static Uniform4iDelegate Uniform4iInstance;
	private static Uniform1fvDelegate Uniform1fvInstance;
	private static Uniform2fvDelegate Uniform2fvInstance;
	private static Uniform3fvDelegate Uniform3fvInstance;
	private static Uniform4fvDelegate Uniform4fvInstance;
	private static Uniform1ivDelegate Uniform1ivInstance;
	private static Uniform2ivDelegate Uniform2ivInstance;
	private static Uniform3ivDelegate Uniform3ivInstance;
	private static Uniform4ivDelegate Uniform4ivInstance;
	private static UniformMatrix2fvDelegate UniformMatrix2fvInstance;
	private static UniformMatrix3fvDelegate UniformMatrix3fvInstance;
	private static UniformMatrix4fvDelegate UniformMatrix4fvInstance;
	private static ValidateProgramDelegate ValidateProgramInstance;
	private static VertexAttrib1dDelegate VertexAttrib1dInstance;
	private static VertexAttrib1dvDelegate VertexAttrib1dvInstance;
	private static VertexAttrib1fDelegate VertexAttrib1fInstance;
	private static VertexAttrib1fvDelegate VertexAttrib1fvInstance;
	private static VertexAttrib1sDelegate VertexAttrib1sInstance;
	private static VertexAttrib1svDelegate VertexAttrib1svInstance;
	private static VertexAttrib2dDelegate VertexAttrib2dInstance;
	private static VertexAttrib2dvDelegate VertexAttrib2dvInstance;
	private static VertexAttrib2fDelegate VertexAttrib2fInstance;
	private static VertexAttrib2fvDelegate VertexAttrib2fvInstance;
	private static VertexAttrib2sDelegate VertexAttrib2sInstance;
	private static VertexAttrib2svDelegate VertexAttrib2svInstance;
	private static VertexAttrib3dDelegate VertexAttrib3dInstance;
	private static VertexAttrib3dvDelegate VertexAttrib3dvInstance;
	private static VertexAttrib3fDelegate VertexAttrib3fInstance;
	private static VertexAttrib3fvDelegate VertexAttrib3fvInstance;
	private static VertexAttrib3sDelegate VertexAttrib3sInstance;
	private static VertexAttrib3svDelegate VertexAttrib3svInstance;
	private static VertexAttrib4NbvDelegate VertexAttrib4NbvInstance;
	private static VertexAttrib4NivDelegate VertexAttrib4NivInstance;
	private static VertexAttrib4NsvDelegate VertexAttrib4NsvInstance;
	private static VertexAttrib4NubDelegate VertexAttrib4NubInstance;
	private static VertexAttrib4NubvDelegate VertexAttrib4NubvInstance;
	private static VertexAttrib4NuivDelegate VertexAttrib4NuivInstance;
	private static VertexAttrib4NusvDelegate VertexAttrib4NusvInstance;
	private static VertexAttrib4bvDelegate VertexAttrib4bvInstance;
	private static VertexAttrib4dDelegate VertexAttrib4dInstance;
	private static VertexAttrib4dvDelegate VertexAttrib4dvInstance;
	private static VertexAttrib4fDelegate VertexAttrib4fInstance;
	private static VertexAttrib4fvDelegate VertexAttrib4fvInstance;
	private static VertexAttrib4ivDelegate VertexAttrib4ivInstance;
	private static VertexAttrib4sDelegate VertexAttrib4sInstance;
	private static VertexAttrib4svDelegate VertexAttrib4svInstance;
	private static VertexAttrib4ubvDelegate VertexAttrib4ubvInstance;
	private static VertexAttrib4uivDelegate VertexAttrib4uivInstance;
	private static VertexAttrib4usvDelegate VertexAttrib4usvInstance;
	private static VertexAttribPointerDelegate VertexAttribPointerInstance;
	private static UniformMatrix2x3fvDelegate UniformMatrix2x3fvInstance;
	private static UniformMatrix3x2fvDelegate UniformMatrix3x2fvInstance;
	private static UniformMatrix2x4fvDelegate UniformMatrix2x4fvInstance;
	private static UniformMatrix4x2fvDelegate UniformMatrix4x2fvInstance;
	private static UniformMatrix3x4fvDelegate UniformMatrix3x4fvInstance;
	private static UniformMatrix4x3fvDelegate UniformMatrix4x3fvInstance;
	private static ColorMaskiDelegate ColorMaskiInstance;
	private static GetBooleani_vDelegate GetBooleani_vInstance;
	private static GetIntegeri_vDelegate GetIntegeri_vInstance;
	private static EnableiDelegate EnableiInstance;
	private static DisableiDelegate DisableiInstance;
	private static IsEnablediDelegate IsEnablediInstance;
	private static BeginTransformFeedbackDelegate BeginTransformFeedbackInstance;
	private static EndTransformFeedbackDelegate EndTransformFeedbackInstance;
	private static BindBufferRangeDelegate BindBufferRangeInstance;
	private static BindBufferBaseDelegate BindBufferBaseInstance;
	private static TransformFeedbackVaryingsDelegate TransformFeedbackVaryingsInstance;
	private static GetTransformFeedbackVaryingDelegate GetTransformFeedbackVaryingInstance;
	private static ClampColorDelegate ClampColorInstance;
	private static BeginConditionalRenderDelegate BeginConditionalRenderInstance;
	private static EndConditionalRenderDelegate EndConditionalRenderInstance;
	private static VertexAttribIPointerDelegate VertexAttribIPointerInstance;
	private static GetVertexAttribIivDelegate GetVertexAttribIivInstance;
	private static GetVertexAttribIuivDelegate GetVertexAttribIuivInstance;
	private static VertexAttribI1iDelegate VertexAttribI1iInstance;
	private static VertexAttribI2iDelegate VertexAttribI2iInstance;
	private static VertexAttribI3iDelegate VertexAttribI3iInstance;
	private static VertexAttribI4iDelegate VertexAttribI4iInstance;
	private static VertexAttribI1uiDelegate VertexAttribI1uiInstance;
	private static VertexAttribI2uiDelegate VertexAttribI2uiInstance;
	private static VertexAttribI3uiDelegate VertexAttribI3uiInstance;
	private static VertexAttribI4uiDelegate VertexAttribI4uiInstance;
	private static VertexAttribI1ivDelegate VertexAttribI1ivInstance;
	private static VertexAttribI2ivDelegate VertexAttribI2ivInstance;
	private static VertexAttribI3ivDelegate VertexAttribI3ivInstance;
	private static VertexAttribI4ivDelegate VertexAttribI4ivInstance;
	private static VertexAttribI1uivDelegate VertexAttribI1uivInstance;
	private static VertexAttribI2uivDelegate VertexAttribI2uivInstance;
	private static VertexAttribI3uivDelegate VertexAttribI3uivInstance;
	private static VertexAttribI4uivDelegate VertexAttribI4uivInstance;
	private static VertexAttribI4bvDelegate VertexAttribI4bvInstance;
	private static VertexAttribI4svDelegate VertexAttribI4svInstance;
	private static VertexAttribI4ubvDelegate VertexAttribI4ubvInstance;
	private static VertexAttribI4usvDelegate VertexAttribI4usvInstance;
	private static GetUniformuivDelegate GetUniformuivInstance;
	private static BindFragDataLocationDelegate BindFragDataLocationInstance;
	private static GetFragDataLocationDelegate GetFragDataLocationInstance;
	private static Uniform1uiDelegate Uniform1uiInstance;
	private static Uniform2uiDelegate Uniform2uiInstance;
	private static Uniform3uiDelegate Uniform3uiInstance;
	private static Uniform4uiDelegate Uniform4uiInstance;
	private static Uniform1uivDelegate Uniform1uivInstance;
	private static Uniform2uivDelegate Uniform2uivInstance;
	private static Uniform3uivDelegate Uniform3uivInstance;
	private static Uniform4uivDelegate Uniform4uivInstance;
	private static TexParameterIivDelegate TexParameterIivInstance;
	private static TexParameterIuivDelegate TexParameterIuivInstance;
	private static GetTexParameterIivDelegate GetTexParameterIivInstance;
	private static GetTexParameterIuivDelegate GetTexParameterIuivInstance;
	private static ClearBufferivDelegate ClearBufferivInstance;
	private static ClearBufferuivDelegate ClearBufferuivInstance;
	private static ClearBufferfvDelegate ClearBufferfvInstance;
	private static ClearBufferfiDelegate ClearBufferfiInstance;
	private static GetStringiDelegate GetStringiInstance;
	private static IsRenderbufferDelegate IsRenderbufferInstance;
	private static BindRenderbufferDelegate BindRenderbufferInstance;
	private static DeleteRenderbuffersDelegate DeleteRenderbuffersInstance;
	private static GenRenderbuffersDelegate GenRenderbuffersInstance;
	private static RenderbufferStorageDelegate RenderbufferStorageInstance;
	private static GetRenderbufferParameterivDelegate GetRenderbufferParameterivInstance;
	private static IsFramebufferDelegate IsFramebufferInstance;
	private static BindFramebufferDelegate BindFramebufferInstance;
	private static DeleteFramebuffersDelegate DeleteFramebuffersInstance;
	private static GenFramebuffersDelegate GenFramebuffersInstance;
	private static CheckFramebufferStatusDelegate CheckFramebufferStatusInstance;
	private static FramebufferTexture1DDelegate FramebufferTexture1DInstance;
	private static FramebufferTexture2DDelegate FramebufferTexture2DInstance;
	private static FramebufferTexture3DDelegate FramebufferTexture3DInstance;
	private static FramebufferRenderbufferDelegate FramebufferRenderbufferInstance;
	private static GetFramebufferAttachmentParameterivDelegate GetFramebufferAttachmentParameterivInstance;
	private static GenerateMipmapDelegate GenerateMipmapInstance;
	private static BlitFramebufferDelegate BlitFramebufferInstance;
	private static RenderbufferStorageMultisampleDelegate RenderbufferStorageMultisampleInstance;
	private static FramebufferTextureLayerDelegate FramebufferTextureLayerInstance;
	private static MapBufferRangeDelegate MapBufferRangeInstance;
	private static FlushMappedBufferRangeDelegate FlushMappedBufferRangeInstance;
	private static BindVertexArrayDelegate BindVertexArrayInstance;
	private static DeleteVertexArraysDelegate DeleteVertexArraysInstance;
	private static GenVertexArraysDelegate GenVertexArraysInstance;
	private static IsVertexArrayDelegate IsVertexArrayInstance;
	private static DrawArraysInstancedDelegate DrawArraysInstancedInstance;
	private static DrawElementsInstancedDelegate DrawElementsInstancedInstance;
	private static TexBufferDelegate TexBufferInstance;
	private static PrimitiveRestartIndexDelegate PrimitiveRestartIndexInstance;
	private static CopyBufferSubDataDelegate CopyBufferSubDataInstance;
	private static GetUniformIndicesDelegate GetUniformIndicesInstance;
	private static GetActiveUniformsivDelegate GetActiveUniformsivInstance;
	private static GetActiveUniformNameDelegate GetActiveUniformNameInstance;
	private static GetUniformBlockIndexDelegate GetUniformBlockIndexInstance;
	private static GetActiveUniformBlockivDelegate GetActiveUniformBlockivInstance;
	private static GetActiveUniformBlockNameDelegate GetActiveUniformBlockNameInstance;
	private static UniformBlockBindingDelegate UniformBlockBindingInstance;
	private static DrawElementsBaseVertexDelegate DrawElementsBaseVertexInstance;
	private static DrawRangeElementsBaseVertexDelegate DrawRangeElementsBaseVertexInstance;
	private static DrawElementsInstancedBaseVertexDelegate DrawElementsInstancedBaseVertexInstance;
	private static MultiDrawElementsBaseVertexDelegate MultiDrawElementsBaseVertexInstance;
	private static ProvokingVertexDelegate ProvokingVertexInstance;
	private static FenceSyncDelegate FenceSyncInstance;
	private static IsSyncDelegate IsSyncInstance;
	private static DeleteSyncDelegate DeleteSyncInstance;
	private static ClientWaitSyncDelegate ClientWaitSyncInstance;
	private static WaitSyncDelegate WaitSyncInstance;
	private static GetInteger64vDelegate GetInteger64vInstance;
	private static GetSyncivDelegate GetSyncivInstance;
	private static GetInteger64i_vDelegate GetInteger64i_vInstance;
	private static GetBufferParameteri64vDelegate GetBufferParameteri64vInstance;
	private static FramebufferTextureDelegate FramebufferTextureInstance;
	private static TexImage2DMultisampleDelegate TexImage2DMultisampleInstance;
	private static TexImage3DMultisampleDelegate TexImage3DMultisampleInstance;
	private static GetMultisamplefvDelegate GetMultisamplefvInstance;
	private static SampleMaskiDelegate SampleMaskiInstance;
	private static BindFragDataLocationIndexedDelegate BindFragDataLocationIndexedInstance;
	private static GetFragDataIndexDelegate GetFragDataIndexInstance;
	private static GenSamplersDelegate GenSamplersInstance;
	private static DeleteSamplersDelegate DeleteSamplersInstance;
	private static IsSamplerDelegate IsSamplerInstance;
	private static BindSamplerDelegate BindSamplerInstance;
	private static SamplerParameteriDelegate SamplerParameteriInstance;
	private static SamplerParameterivDelegate SamplerParameterivInstance;
	private static SamplerParameterfDelegate SamplerParameterfInstance;
	private static SamplerParameterfvDelegate SamplerParameterfvInstance;
	private static SamplerParameterIivDelegate SamplerParameterIivInstance;
	private static SamplerParameterIuivDelegate SamplerParameterIuivInstance;
	private static GetSamplerParameterivDelegate GetSamplerParameterivInstance;
	private static GetSamplerParameterIivDelegate GetSamplerParameterIivInstance;
	private static GetSamplerParameterfvDelegate GetSamplerParameterfvInstance;
	private static GetSamplerParameterIuivDelegate GetSamplerParameterIuivInstance;
	private static QueryCounterDelegate QueryCounterInstance;
	private static GetQueryObjecti64vDelegate GetQueryObjecti64vInstance;
	private static GetQueryObjectui64vDelegate GetQueryObjectui64vInstance;
	private static VertexAttribDivisorDelegate VertexAttribDivisorInstance;
	private static VertexAttribP1uiDelegate VertexAttribP1uiInstance;
	private static VertexAttribP1uivDelegate VertexAttribP1uivInstance;
	private static VertexAttribP2uiDelegate VertexAttribP2uiInstance;
	private static VertexAttribP2uivDelegate VertexAttribP2uivInstance;
	private static VertexAttribP3uiDelegate VertexAttribP3uiInstance;
	private static VertexAttribP3uivDelegate VertexAttribP3uivInstance;
	private static VertexAttribP4uiDelegate VertexAttribP4uiInstance;
	private static VertexAttribP4uivDelegate VertexAttribP4uivInstance;
	private static MinSampleShadingDelegate MinSampleShadingInstance;
	private static BlendEquationiDelegate BlendEquationiInstance;
	private static BlendEquationSeparateiDelegate BlendEquationSeparateiInstance;
	private static BlendFunciDelegate BlendFunciInstance;
	private static BlendFuncSeparateiDelegate BlendFuncSeparateiInstance;
	private static DrawArraysIndirectDelegate DrawArraysIndirectInstance;
	private static DrawElementsIndirectDelegate DrawElementsIndirectInstance;
	private static Uniform1dDelegate Uniform1dInstance;
	private static Uniform2dDelegate Uniform2dInstance;
	private static Uniform3dDelegate Uniform3dInstance;
	private static Uniform4dDelegate Uniform4dInstance;
	private static Uniform1dvDelegate Uniform1dvInstance;
	private static Uniform2dvDelegate Uniform2dvInstance;
	private static Uniform3dvDelegate Uniform3dvInstance;
	private static Uniform4dvDelegate Uniform4dvInstance;
	private static UniformMatrix2dvDelegate UniformMatrix2dvInstance;
	private static UniformMatrix3dvDelegate UniformMatrix3dvInstance;
	private static UniformMatrix4dvDelegate UniformMatrix4dvInstance;
	private static UniformMatrix2x3dvDelegate UniformMatrix2x3dvInstance;
	private static UniformMatrix2x4dvDelegate UniformMatrix2x4dvInstance;
	private static UniformMatrix3x2dvDelegate UniformMatrix3x2dvInstance;
	private static UniformMatrix3x4dvDelegate UniformMatrix3x4dvInstance;
	private static UniformMatrix4x2dvDelegate UniformMatrix4x2dvInstance;
	private static UniformMatrix4x3dvDelegate UniformMatrix4x3dvInstance;
	private static GetUniformdvDelegate GetUniformdvInstance;
	private static GetSubroutineUniformLocationDelegate GetSubroutineUniformLocationInstance;
	private static GetSubroutineIndexDelegate GetSubroutineIndexInstance;
	private static GetActiveSubroutineUniformivDelegate GetActiveSubroutineUniformivInstance;
	private static GetActiveSubroutineUniformNameDelegate GetActiveSubroutineUniformNameInstance;
	private static GetActiveSubroutineNameDelegate GetActiveSubroutineNameInstance;
	private static UniformSubroutinesuivDelegate UniformSubroutinesuivInstance;
	private static GetUniformSubroutineuivDelegate GetUniformSubroutineuivInstance;
	private static GetProgramStageivDelegate GetProgramStageivInstance;
	private static PatchParameteriDelegate PatchParameteriInstance;
	private static PatchParameterfvDelegate PatchParameterfvInstance;
	private static BindTransformFeedbackDelegate BindTransformFeedbackInstance;
	private static DeleteTransformFeedbacksDelegate DeleteTransformFeedbacksInstance;
	private static GenTransformFeedbacksDelegate GenTransformFeedbacksInstance;
	private static IsTransformFeedbackDelegate IsTransformFeedbackInstance;
	private static PauseTransformFeedbackDelegate PauseTransformFeedbackInstance;
	private static ResumeTransformFeedbackDelegate ResumeTransformFeedbackInstance;
	private static DrawTransformFeedbackDelegate DrawTransformFeedbackInstance;
	private static DrawTransformFeedbackStreamDelegate DrawTransformFeedbackStreamInstance;
	private static BeginQueryIndexedDelegate BeginQueryIndexedInstance;
	private static EndQueryIndexedDelegate EndQueryIndexedInstance;
	private static GetQueryIndexedivDelegate GetQueryIndexedivInstance;
	private static ReleaseShaderCompilerDelegate ReleaseShaderCompilerInstance;
	private static ShaderBinaryDelegate ShaderBinaryInstance;
	private static GetShaderPrecisionFormatDelegate GetShaderPrecisionFormatInstance;
	private static DepthRangefDelegate DepthRangefInstance;
	private static ClearDepthfDelegate ClearDepthfInstance;
	private static GetProgramBinaryDelegate GetProgramBinaryInstance;
	private static ProgramBinaryDelegate ProgramBinaryInstance;
	private static ProgramParameteriDelegate ProgramParameteriInstance;
	private static UseProgramStagesDelegate UseProgramStagesInstance;
	private static ActiveShaderProgramDelegate ActiveShaderProgramInstance;
	private static CreateShaderProgramvDelegate CreateShaderProgramvInstance;
	private static BindProgramPipelineDelegate BindProgramPipelineInstance;
	private static DeleteProgramPipelinesDelegate DeleteProgramPipelinesInstance;
	private static GenProgramPipelinesDelegate GenProgramPipelinesInstance;
	private static IsProgramPipelineDelegate IsProgramPipelineInstance;
	private static GetProgramPipelineivDelegate GetProgramPipelineivInstance;
	private static ProgramUniform1iDelegate ProgramUniform1iInstance;
	private static ProgramUniform1ivDelegate ProgramUniform1ivInstance;
	private static ProgramUniform1fDelegate ProgramUniform1fInstance;
	private static ProgramUniform1fvDelegate ProgramUniform1fvInstance;
	private static ProgramUniform1dDelegate ProgramUniform1dInstance;
	private static ProgramUniform1dvDelegate ProgramUniform1dvInstance;
	private static ProgramUniform1uiDelegate ProgramUniform1uiInstance;
	private static ProgramUniform1uivDelegate ProgramUniform1uivInstance;
	private static ProgramUniform2iDelegate ProgramUniform2iInstance;
	private static ProgramUniform2ivDelegate ProgramUniform2ivInstance;
	private static ProgramUniform2fDelegate ProgramUniform2fInstance;
	private static ProgramUniform2fvDelegate ProgramUniform2fvInstance;
	private static ProgramUniform2dDelegate ProgramUniform2dInstance;
	private static ProgramUniform2dvDelegate ProgramUniform2dvInstance;
	private static ProgramUniform2uiDelegate ProgramUniform2uiInstance;
	private static ProgramUniform2uivDelegate ProgramUniform2uivInstance;
	private static ProgramUniform3iDelegate ProgramUniform3iInstance;
	private static ProgramUniform3ivDelegate ProgramUniform3ivInstance;
	private static ProgramUniform3fDelegate ProgramUniform3fInstance;
	private static ProgramUniform3fvDelegate ProgramUniform3fvInstance;
	private static ProgramUniform3dDelegate ProgramUniform3dInstance;
	private static ProgramUniform3dvDelegate ProgramUniform3dvInstance;
	private static ProgramUniform3uiDelegate ProgramUniform3uiInstance;
	private static ProgramUniform3uivDelegate ProgramUniform3uivInstance;
	private static ProgramUniform4iDelegate ProgramUniform4iInstance;
	private static ProgramUniform4ivDelegate ProgramUniform4ivInstance;
	private static ProgramUniform4fDelegate ProgramUniform4fInstance;
	private static ProgramUniform4fvDelegate ProgramUniform4fvInstance;
	private static ProgramUniform4dDelegate ProgramUniform4dInstance;
	private static ProgramUniform4dvDelegate ProgramUniform4dvInstance;
	private static ProgramUniform4uiDelegate ProgramUniform4uiInstance;
	private static ProgramUniform4uivDelegate ProgramUniform4uivInstance;
	private static ProgramUniformMatrix2fvDelegate ProgramUniformMatrix2fvInstance;
	private static ProgramUniformMatrix3fvDelegate ProgramUniformMatrix3fvInstance;
	private static ProgramUniformMatrix4fvDelegate ProgramUniformMatrix4fvInstance;
	private static ProgramUniformMatrix2dvDelegate ProgramUniformMatrix2dvInstance;
	private static ProgramUniformMatrix3dvDelegate ProgramUniformMatrix3dvInstance;
	private static ProgramUniformMatrix4dvDelegate ProgramUniformMatrix4dvInstance;
	private static ProgramUniformMatrix2x3fvDelegate ProgramUniformMatrix2x3fvInstance;
	private static ProgramUniformMatrix3x2fvDelegate ProgramUniformMatrix3x2fvInstance;
	private static ProgramUniformMatrix2x4fvDelegate ProgramUniformMatrix2x4fvInstance;
	private static ProgramUniformMatrix4x2fvDelegate ProgramUniformMatrix4x2fvInstance;
	private static ProgramUniformMatrix3x4fvDelegate ProgramUniformMatrix3x4fvInstance;
	private static ProgramUniformMatrix4x3fvDelegate ProgramUniformMatrix4x3fvInstance;
	private static ProgramUniformMatrix2x3dvDelegate ProgramUniformMatrix2x3dvInstance;
	private static ProgramUniformMatrix3x2dvDelegate ProgramUniformMatrix3x2dvInstance;
	private static ProgramUniformMatrix2x4dvDelegate ProgramUniformMatrix2x4dvInstance;
	private static ProgramUniformMatrix4x2dvDelegate ProgramUniformMatrix4x2dvInstance;
	private static ProgramUniformMatrix3x4dvDelegate ProgramUniformMatrix3x4dvInstance;
	private static ProgramUniformMatrix4x3dvDelegate ProgramUniformMatrix4x3dvInstance;
	private static ValidateProgramPipelineDelegate ValidateProgramPipelineInstance;
	private static GetProgramPipelineInfoLogDelegate GetProgramPipelineInfoLogInstance;
	private static VertexAttribL1dDelegate VertexAttribL1dInstance;
	private static VertexAttribL2dDelegate VertexAttribL2dInstance;
	private static VertexAttribL3dDelegate VertexAttribL3dInstance;
	private static VertexAttribL4dDelegate VertexAttribL4dInstance;
	private static VertexAttribL1dvDelegate VertexAttribL1dvInstance;
	private static VertexAttribL2dvDelegate VertexAttribL2dvInstance;
	private static VertexAttribL3dvDelegate VertexAttribL3dvInstance;
	private static VertexAttribL4dvDelegate VertexAttribL4dvInstance;
	private static VertexAttribLPointerDelegate VertexAttribLPointerInstance;
	private static GetVertexAttribLdvDelegate GetVertexAttribLdvInstance;
	private static ViewportArrayvDelegate ViewportArrayvInstance;
	private static ViewportIndexedfDelegate ViewportIndexedfInstance;
	private static ViewportIndexedfvDelegate ViewportIndexedfvInstance;
	private static ScissorArrayvDelegate ScissorArrayvInstance;
	private static ScissorIndexedDelegate ScissorIndexedInstance;
	private static ScissorIndexedvDelegate ScissorIndexedvInstance;
	private static DepthRangeArrayvDelegate DepthRangeArrayvInstance;
	private static DepthRangeIndexedDelegate DepthRangeIndexedInstance;
	private static GetFloati_vDelegate GetFloati_vInstance;
	private static GetDoublei_vDelegate GetDoublei_vInstance;
	private static DrawArraysInstancedBaseInstanceDelegate DrawArraysInstancedBaseInstanceInstance;
	private static DrawElementsInstancedBaseInstanceDelegate DrawElementsInstancedBaseInstanceInstance;
	private static DrawElementsInstancedBaseVertexBaseInstanceDelegate DrawElementsInstancedBaseVertexBaseInstanceInstance;
	private static GetInternalformativDelegate GetInternalformativInstance;
	private static GetActiveAtomicCounterBufferivDelegate GetActiveAtomicCounterBufferivInstance;
	private static BindImageTextureDelegate BindImageTextureInstance;
	private static MemoryBarrierDelegate MemoryBarrierInstance;
	private static TexStorage1DDelegate TexStorage1DInstance;
	private static TexStorage2DDelegate TexStorage2DInstance;
	private static TexStorage3DDelegate TexStorage3DInstance;
	private static DrawTransformFeedbackInstancedDelegate DrawTransformFeedbackInstancedInstance;
	private static DrawTransformFeedbackStreamInstancedDelegate DrawTransformFeedbackStreamInstancedInstance;
	private static ClearBufferDataDelegate ClearBufferDataInstance;
	private static ClearBufferSubDataDelegate ClearBufferSubDataInstance;
	private static DispatchComputeDelegate DispatchComputeInstance;
	private static DispatchComputeIndirectDelegate DispatchComputeIndirectInstance;
	private static CopyImageSubDataDelegate CopyImageSubDataInstance;
	private static FramebufferParameteriDelegate FramebufferParameteriInstance;
	private static GetFramebufferParameterivDelegate GetFramebufferParameterivInstance;
	private static GetInternalformati64vDelegate GetInternalformati64vInstance;
	private static InvalidateTexSubImageDelegate InvalidateTexSubImageInstance;
	private static InvalidateTexImageDelegate InvalidateTexImageInstance;
	private static InvalidateBufferSubDataDelegate InvalidateBufferSubDataInstance;
	private static InvalidateBufferDataDelegate InvalidateBufferDataInstance;
	private static InvalidateFramebufferDelegate InvalidateFramebufferInstance;
	private static InvalidateSubFramebufferDelegate InvalidateSubFramebufferInstance;
	private static MultiDrawArraysIndirectDelegate MultiDrawArraysIndirectInstance;
	private static MultiDrawElementsIndirectDelegate MultiDrawElementsIndirectInstance;
	private static GetProgramInterfaceivDelegate GetProgramInterfaceivInstance;
	private static GetProgramResourceIndexDelegate GetProgramResourceIndexInstance;
	private static GetProgramResourceNameDelegate GetProgramResourceNameInstance;
	private static GetProgramResourceivDelegate GetProgramResourceivInstance;
	private static GetProgramResourceLocationDelegate GetProgramResourceLocationInstance;
	private static GetProgramResourceLocationIndexDelegate GetProgramResourceLocationIndexInstance;
	private static ShaderStorageBlockBindingDelegate ShaderStorageBlockBindingInstance;
	private static TexBufferRangeDelegate TexBufferRangeInstance;
	private static TexStorage2DMultisampleDelegate TexStorage2DMultisampleInstance;
	private static TexStorage3DMultisampleDelegate TexStorage3DMultisampleInstance;
	private static TextureViewDelegate TextureViewInstance;
	private static BindVertexBufferDelegate BindVertexBufferInstance;
	private static VertexAttribFormatDelegate VertexAttribFormatInstance;
	private static VertexAttribIFormatDelegate VertexAttribIFormatInstance;
	private static VertexAttribLFormatDelegate VertexAttribLFormatInstance;
	private static VertexAttribBindingDelegate VertexAttribBindingInstance;
	private static VertexBindingDivisorDelegate VertexBindingDivisorInstance;
	private static GetPointervDelegate GetPointervInstance;
	private static BufferStorageDelegate BufferStorageInstance;
	private static ClearTexImageDelegate ClearTexImageInstance;
	private static ClearTexSubImageDelegate ClearTexSubImageInstance;
	private static BindBuffersBaseDelegate BindBuffersBaseInstance;
	private static BindBuffersRangeDelegate BindBuffersRangeInstance;
	private static BindTexturesDelegate BindTexturesInstance;
	private static BindSamplersDelegate BindSamplersInstance;
	private static BindImageTexturesDelegate BindImageTexturesInstance;
	private static BindVertexBuffersDelegate BindVertexBuffersInstance;
	private static ClipControlDelegate ClipControlInstance;
	private static CreateTransformFeedbacksDelegate CreateTransformFeedbacksInstance;
	private static TransformFeedbackBufferBaseDelegate TransformFeedbackBufferBaseInstance;
	private static TransformFeedbackBufferRangeDelegate TransformFeedbackBufferRangeInstance;
	private static GetTransformFeedbackivDelegate GetTransformFeedbackivInstance;
	private static GetTransformFeedbacki_vDelegate GetTransformFeedbacki_vInstance;
	private static GetTransformFeedbacki64_vDelegate GetTransformFeedbacki64_vInstance;
	private static CreateBuffersDelegate CreateBuffersInstance;
	private static NamedBufferStorageDelegate NamedBufferStorageInstance;
	private static NamedBufferDataDelegate NamedBufferDataInstance;
	private static NamedBufferSubDataDelegate NamedBufferSubDataInstance;
	private static CopyNamedBufferSubDataDelegate CopyNamedBufferSubDataInstance;
	private static ClearNamedBufferDataDelegate ClearNamedBufferDataInstance;
	private static ClearNamedBufferSubDataDelegate ClearNamedBufferSubDataInstance;
	private static MapNamedBufferDelegate MapNamedBufferInstance;
	private static MapNamedBufferRangeDelegate MapNamedBufferRangeInstance;
	private static UnmapNamedBufferDelegate UnmapNamedBufferInstance;
	private static FlushMappedNamedBufferRangeDelegate FlushMappedNamedBufferRangeInstance;
	private static GetNamedBufferParameterivDelegate GetNamedBufferParameterivInstance;
	private static GetNamedBufferParameteri64vDelegate GetNamedBufferParameteri64vInstance;
	private static GetNamedBufferPointervDelegate GetNamedBufferPointervInstance;
	private static GetNamedBufferSubDataDelegate GetNamedBufferSubDataInstance;
	private static CreateFramebuffersDelegate CreateFramebuffersInstance;
	private static NamedFramebufferRenderbufferDelegate NamedFramebufferRenderbufferInstance;
	private static NamedFramebufferParameteriDelegate NamedFramebufferParameteriInstance;
	private static NamedFramebufferTextureDelegate NamedFramebufferTextureInstance;
	private static NamedFramebufferTextureLayerDelegate NamedFramebufferTextureLayerInstance;
	private static NamedFramebufferDrawBufferDelegate NamedFramebufferDrawBufferInstance;
	private static NamedFramebufferDrawBuffersDelegate NamedFramebufferDrawBuffersInstance;
	private static NamedFramebufferReadBufferDelegate NamedFramebufferReadBufferInstance;
	private static InvalidateNamedFramebufferDataDelegate InvalidateNamedFramebufferDataInstance;
	private static InvalidateNamedFramebufferSubDataDelegate InvalidateNamedFramebufferSubDataInstance;
	private static ClearNamedFramebufferivDelegate ClearNamedFramebufferivInstance;
	private static ClearNamedFramebufferuivDelegate ClearNamedFramebufferuivInstance;
	private static ClearNamedFramebufferfvDelegate ClearNamedFramebufferfvInstance;
	private static ClearNamedFramebufferfiDelegate ClearNamedFramebufferfiInstance;
	private static BlitNamedFramebufferDelegate BlitNamedFramebufferInstance;
	private static CheckNamedFramebufferStatusDelegate CheckNamedFramebufferStatusInstance;
	private static GetNamedFramebufferParameterivDelegate GetNamedFramebufferParameterivInstance;
	private static GetNamedFramebufferAttachmentParameterivDelegate GetNamedFramebufferAttachmentParameterivInstance;
	private static CreateRenderbuffersDelegate CreateRenderbuffersInstance;
	private static NamedRenderbufferStorageDelegate NamedRenderbufferStorageInstance;
	private static NamedRenderbufferStorageMultisampleDelegate NamedRenderbufferStorageMultisampleInstance;
	private static GetNamedRenderbufferParameterivDelegate GetNamedRenderbufferParameterivInstance;
	private static CreateTexturesDelegate CreateTexturesInstance;
	private static TextureBufferDelegate TextureBufferInstance;
	private static TextureBufferRangeDelegate TextureBufferRangeInstance;
	private static TextureStorage1DDelegate TextureStorage1DInstance;
	private static TextureStorage2DDelegate TextureStorage2DInstance;
	private static TextureStorage3DDelegate TextureStorage3DInstance;
	private static TextureStorage2DMultisampleDelegate TextureStorage2DMultisampleInstance;
	private static TextureStorage3DMultisampleDelegate TextureStorage3DMultisampleInstance;
	private static TextureSubImage1DDelegate TextureSubImage1DInstance;
	private static TextureSubImage2DDelegate TextureSubImage2DInstance;
	private static TextureSubImage3DDelegate TextureSubImage3DInstance;
	private static CompressedTextureSubImage1DDelegate CompressedTextureSubImage1DInstance;
	private static CompressedTextureSubImage2DDelegate CompressedTextureSubImage2DInstance;
	private static CompressedTextureSubImage3DDelegate CompressedTextureSubImage3DInstance;
	private static CopyTextureSubImage1DDelegate CopyTextureSubImage1DInstance;
	private static CopyTextureSubImage2DDelegate CopyTextureSubImage2DInstance;
	private static CopyTextureSubImage3DDelegate CopyTextureSubImage3DInstance;
	private static TextureParameterfDelegate TextureParameterfInstance;
	private static TextureParameterfvDelegate TextureParameterfvInstance;
	private static TextureParameteriDelegate TextureParameteriInstance;
	private static TextureParameterIivDelegate TextureParameterIivInstance;
	private static TextureParameterIuivDelegate TextureParameterIuivInstance;
	private static TextureParameterivDelegate TextureParameterivInstance;
	private static GenerateTextureMipmapDelegate GenerateTextureMipmapInstance;
	private static BindTextureUnitDelegate BindTextureUnitInstance;
	private static GetTextureImageDelegate GetTextureImageInstance;
	private static GetCompressedTextureImageDelegate GetCompressedTextureImageInstance;
	private static GetTextureLevelParameterfvDelegate GetTextureLevelParameterfvInstance;
	private static GetTextureLevelParameterivDelegate GetTextureLevelParameterivInstance;
	private static GetTextureParameterfvDelegate GetTextureParameterfvInstance;
	private static GetTextureParameterIivDelegate GetTextureParameterIivInstance;
	private static GetTextureParameterIuivDelegate GetTextureParameterIuivInstance;
	private static GetTextureParameterivDelegate GetTextureParameterivInstance;
	private static CreateVertexArraysDelegate CreateVertexArraysInstance;
	private static DisableVertexArrayAttribDelegate DisableVertexArrayAttribInstance;
	private static EnableVertexArrayAttribDelegate EnableVertexArrayAttribInstance;
	private static VertexArrayElementBufferDelegate VertexArrayElementBufferInstance;
	private static VertexArrayVertexBufferDelegate VertexArrayVertexBufferInstance;
	private static VertexArrayVertexBuffersDelegate VertexArrayVertexBuffersInstance;
	private static VertexArrayAttribBindingDelegate VertexArrayAttribBindingInstance;
	private static VertexArrayAttribFormatDelegate VertexArrayAttribFormatInstance;
	private static VertexArrayAttribIFormatDelegate VertexArrayAttribIFormatInstance;
	private static VertexArrayAttribLFormatDelegate VertexArrayAttribLFormatInstance;
	private static VertexArrayBindingDivisorDelegate VertexArrayBindingDivisorInstance;
	private static GetVertexArrayivDelegate GetVertexArrayivInstance;
	private static GetVertexArrayIndexedivDelegate GetVertexArrayIndexedivInstance;
	private static GetVertexArrayIndexed64ivDelegate GetVertexArrayIndexed64ivInstance;
	private static CreateSamplersDelegate CreateSamplersInstance;
	private static CreateProgramPipelinesDelegate CreateProgramPipelinesInstance;
	private static CreateQueriesDelegate CreateQueriesInstance;
	private static GetQueryBufferObjecti64vDelegate GetQueryBufferObjecti64vInstance;
	private static GetQueryBufferObjectivDelegate GetQueryBufferObjectivInstance;
	private static GetQueryBufferObjectui64vDelegate GetQueryBufferObjectui64vInstance;
	private static GetQueryBufferObjectuivDelegate GetQueryBufferObjectuivInstance;
	private static MemoryBarrierByRegionDelegate MemoryBarrierByRegionInstance;
	private static GetTextureSubImageDelegate GetTextureSubImageInstance;
	private static GetCompressedTextureSubImageDelegate GetCompressedTextureSubImageInstance;
	private static GetGraphicsResetStatusDelegate GetGraphicsResetStatusInstance;
	private static GetnCompressedTexImageDelegate GetnCompressedTexImageInstance;
	private static GetnTexImageDelegate GetnTexImageInstance;
	private static GetnUniformdvDelegate GetnUniformdvInstance;
	private static GetnUniformfvDelegate GetnUniformfvInstance;
	private static GetnUniformivDelegate GetnUniformivInstance;
	private static GetnUniformuivDelegate GetnUniformuivInstance;
	private static ReadnPixelsDelegate ReadnPixelsInstance;
	private static TextureBarrierDelegate TextureBarrierInstance;
#pragma warning restore CS8618
	#endregion
	#region FunctionDefinitions
	internal static uint GenTexture()
	{
		GenTexturesInstance(1, out uint val);
		return val;
	}
	internal static void GenTextures(Span<uint> span)
	{
		GenTexturesInstance(span.Length, out MemoryMarshal.GetReference(span));
	}
	internal static uint GenQuery()
	{
		GenQueriesInstance(1, out uint val);
		return val;
	}
	internal static void GenQueries(Span<uint> span)
	{
		GenQueriesInstance(span.Length, out MemoryMarshal.GetReference(span));
	}
	internal static uint GenBuffer()
	{
		GenBuffersInstance(1, out uint val);
		return val;
	}
	internal static void GenBuffers(Span<uint> span)
	{
		GenBuffersInstance(span.Length, out MemoryMarshal.GetReference(span));
	}
	internal static uint GenRenderbuffer()
	{
		GenRenderbuffersInstance(1, out uint val);
		return val;
	}
	internal static void GenRenderbuffers(Span<uint> span)
	{
		GenRenderbuffersInstance(span.Length, out MemoryMarshal.GetReference(span));
	}
	internal static uint GenFramebuffer()
	{
		GenFramebuffersInstance(1, out uint val);
		return val;
	}
	internal static void GenFramebuffers(Span<uint> span)
	{
		GenFramebuffersInstance(span.Length, out MemoryMarshal.GetReference(span));
	}
	internal static uint GenVertexArray()
	{
		GenVertexArraysInstance(1, out uint val);
		return val;
	}
	internal static void GenVertexArrays(Span<uint> span)
	{
		GenVertexArraysInstance(span.Length, out MemoryMarshal.GetReference(span));
	}
	internal static uint GenSampler()
	{
		GenSamplersInstance(1, out uint val);
		return val;
	}
	internal static void GenSamplers(Span<uint> span)
	{
		GenSamplersInstance(span.Length, out MemoryMarshal.GetReference(span));
	}
	internal static uint GenTransformFeedback()
	{
		GenTransformFeedbacksInstance(1, out uint val);
		return val;
	}
	internal static void GenTransformFeedbacks(Span<uint> span)
	{
		GenTransformFeedbacksInstance(span.Length, out MemoryMarshal.GetReference(span));
	}
	internal static uint GenProgramPipeline()
	{
		GenProgramPipelinesInstance(1, out uint val);
		return val;
	}
	internal static void GenProgramPipelines(Span<uint> span)
	{
		GenProgramPipelinesInstance(span.Length, out MemoryMarshal.GetReference(span));
	}
	internal static uint CreateTransformFeedback()
	{
		CreateTransformFeedbacksInstance(1, out uint val);
		return val;
	}
	internal static void CreateTransformFeedbacks(Span<uint> span)
	{
		CreateTransformFeedbacksInstance(span.Length, out MemoryMarshal.GetReference(span));
	}
	internal static uint CreateBuffer()
	{
		CreateBuffersInstance(1, out uint val);
		return val;
	}
	internal static void CreateBuffers(Span<uint> span)
	{
		CreateBuffersInstance(span.Length, out MemoryMarshal.GetReference(span));
	}
	internal static uint CreateFramebuffer()
	{
		CreateFramebuffersInstance(1, out uint val);
		return val;
	}
	internal static void CreateFramebuffers(Span<uint> span)
	{
		CreateFramebuffersInstance(span.Length, out MemoryMarshal.GetReference(span));
	}
	internal static uint CreateRenderbuffer()
	{
		CreateRenderbuffersInstance(1, out uint val);
		return val;
	}
	internal static void CreateRenderbuffers(Span<uint> span)
	{
		CreateRenderbuffersInstance(span.Length, out MemoryMarshal.GetReference(span));
	}
	internal static uint CreateVertexArray()
	{
		CreateVertexArraysInstance(1, out uint val);
		return val;
	}
	internal static void CreateVertexArrays(Span<uint> span)
	{
		CreateVertexArraysInstance(span.Length, out MemoryMarshal.GetReference(span));
	}
	internal static uint CreateSampler()
	{
		CreateSamplersInstance(1, out uint val);
		return val;
	}
	internal static void CreateSamplers(Span<uint> span)
	{
		CreateSamplersInstance(span.Length, out MemoryMarshal.GetReference(span));
	}
	internal static uint CreateProgramPipeline()
	{
		CreateProgramPipelinesInstance(1, out uint val);
		return val;
	}
	internal static void CreateProgramPipelines(Span<uint> span)
	{
		CreateProgramPipelinesInstance(span.Length, out MemoryMarshal.GetReference(span));
	}
	internal static void ShaderSource(uint shader, string source)
	{
		var ptr = Marshal.StringToHGlobalAnsi(source);
		var len = source.Length;
		ShaderSourceInstance(shader, 1, in ptr, in len);
		Marshal.FreeHGlobal(ptr);
	}

	internal static void ClearColor(float v1, float v2, float v3, float v4)
	{
		ClearColorInstance(v1, v2, v3, v4);
	}

	internal static uint CreateProgram()
	{
		return CreateProgramInstance();
	}

	internal static uint CreateShader(ShaderType type)
	{
		return CreateShaderInstance(type);
	}

	internal static void CompileShader(uint shader)
	{
		CompileShaderInstance(shader);
	}

	internal static void AttachShader(uint program, uint shader)
	{
		AttachShaderInstance(program, shader);
	}

	internal static void LinkProgram(uint program)
	{
		LinkProgramInstance(program);
	}

	internal static void BindVertexArray(uint vao)
	{
		BindVertexArrayInstance(vao);
	}

	internal static void EnableVertexAttribArray(uint index)
	{
		EnableVertexAttribArrayInstance(index);
	}

	internal static void VertexAttribPointer(uint index, int size, VertexAttribPointerType type, bool normalized, int stride, nint offset)
	{
		VertexAttribPointerInstance(index, size, type, normalized, stride, offset);
	}

	internal static ErrorCode GetError()
	{
		return GetErrorInstance();
	}

	internal static string GetShaderInfoLog(uint shader)
	{
		int size = GetShader(shader, ShaderParameterName.InfoLogLength);
		if (size == 0)
			return "";
		var ptr = Marshal.AllocCoTaskMem(size);
		GetShaderInfoLogInstance(shader, size, out int len, ptr);
		string res = Marshal.PtrToStringAnsi(ptr, len)!;
		Marshal.FreeCoTaskMem(ptr);
		return res;
	}

	internal static int GetShader(uint shader, ShaderParameterName pname) {
		GetShaderivInstance(shader, pname, out int res);
		return res;
	}

	internal static void UseProgram(uint program)
	{
		UseProgramInstance(program);
	}

	internal static void BindBuffer(BufferTarget target, uint buffer)
	{
		BindBufferInstance(target, buffer);
	}

	internal static void BufferData<T>(BufferTarget target, ReadOnlySpan<T> data, BufferUsage usage) where T : unmanaged
	{
		BufferDataInstance(target, data.Length * Marshal.SizeOf<T>(), in MemoryMarshal.GetReference(MemoryMarshal.AsBytes(data)), usage);
	}

	internal static void DrawElements(PrimitiveType mode, int count, DrawElementsType type, int offset)
	{
		DrawElementsInstance(mode, count, type, offset);
	}

	internal static void Clear(ClearBufferMask mask)
	{
		ClearInstance(mask);
	}

    internal static string GetString(StringName name)
    {
		var ptr = GetStringInstance(name);
		return Marshal.PtrToStringAnsi(ptr)!;
    }

    internal static void DebugMessageCallback(DebugProc callback)
    {
        PrivateDebugProc wrapper = (src, t, id, sev, l, msg, up) => {
			callback(src, t, id, sev, Marshal.PtrToStringAnsi(msg, l)!);
		};
		DebugMessageCallbackInstance(wrapper, 0);
    }

    internal static void DebugMessageInsert(DebugSource source, DebugType type, uint id, DebugSeverity severity, string message)
    {
		var ptr = Marshal.StringToCoTaskMemAnsi(message);
        DebugMessageInsertInstance(source, type, id, severity, message.Length, ptr);
		Marshal.FreeCoTaskMem(ptr);
    }

    internal static void Enable(EnableCap cap)
    {
        EnableInstance(cap);
    }

	internal static void DeleteBuffer(uint buffer) {
		DeleteBuffersInstance(1, in buffer);
	}

    #endregion

    private delegate void PrivateDebugProc(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, IntPtr message, IntPtr userParam);
	internal delegate void DebugProc(DebugSource source, DebugType type, uint id, DebugSeverity severity, string message);
	private delegate void PrivateDebugProcARB(uint source, uint type, uint id, uint severity, int length, in sbyte message, in byte userParam);
	private delegate void PrivateDebugProcKHR(uint source, uint type, uint id, uint severity, int length, in sbyte message, in byte userParam);
	private delegate void PrivateDebugProcAMD(uint id, uint category, uint severity, int length, in sbyte message, out byte userParam);
	private delegate void PrivateVulkanProcNV();
}
